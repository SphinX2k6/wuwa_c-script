using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3F RID: 2879
	[NetMessage(EMessageId.NewTowerTaskDataUpdateNotify)]
	public sealed class NewTowerTaskDataUpdateNotify : IMessage<NewTowerTaskDataUpdateNotify>, IMessage, IEquatable<NewTowerTaskDataUpdateNotify>, IDeepCloneable<NewTowerTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600FA01 RID: 64001 RVA: 0x002475C1 File Offset: 0x002457C1
		[NullableContext(1)]
		public static NewTowerTaskDataUpdateNotify Create()
		{
			return new NewTowerTaskDataUpdateNotify();
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600FA02 RID: 64002 RVA: 0x002475C8 File Offset: 0x002457C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600FA03 RID: 64003 RVA: 0x002475CB File Offset: 0x002457CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600FA04 RID: 64004 RVA: 0x002475D2 File Offset: 0x002457D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600FA05 RID: 64005 RVA: 0x002475E5 File Offset: 0x002457E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTaskDataUpdateNotify(NewTowerTaskDataUpdateNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA06 RID: 64006 RVA: 0x0024760F File Offset: 0x0024580F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTaskDataUpdateNotify Clone()
		{
			return new NewTowerTaskDataUpdateNotify(this);
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600FA07 RID: 64007 RVA: 0x00247617 File Offset: 0x00245817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x0600FA08 RID: 64008 RVA: 0x0024761F File Offset: 0x0024581F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerTaskDataUpdateNotify);
		}

		// Token: 0x0600FA09 RID: 64009 RVA: 0x0024762D File Offset: 0x0024582D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA0A RID: 64010 RVA: 0x00247660 File Offset: 0x00245860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA0B RID: 64011 RVA: 0x00247694 File Offset: 0x00245894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA0C RID: 64012 RVA: 0x002476A1 File Offset: 0x002458A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA0D RID: 64013 RVA: 0x002476AA File Offset: 0x002458AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, NewTowerTaskDataUpdateNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA0E RID: 64014 RVA: 0x002476D4 File Offset: 0x002458D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(NewTowerTaskDataUpdateNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA0F RID: 64015 RVA: 0x0024770D File Offset: 0x0024590D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerTaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA10 RID: 64016 RVA: 0x0024773B File Offset: 0x0024593B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA11 RID: 64017 RVA: 0x00247744 File Offset: 0x00245944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, NewTowerTaskDataUpdateNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04006475 RID: 25717
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006476 RID: 25718
		public const int ActivityTasksFieldNumber = 13;

		// Token: 0x04006477 RID: 25719
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(106U, ActivityTask.Parser);

		// Token: 0x04006478 RID: 25720
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
