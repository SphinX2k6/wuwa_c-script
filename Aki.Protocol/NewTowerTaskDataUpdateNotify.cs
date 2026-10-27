using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B50 RID: 2896
	[NetMessage(EMessageId.NewTowerTaskDataUpdateNotify)]
	public sealed class NewTowerTaskDataUpdateNotify : IMessage<NewTowerTaskDataUpdateNotify>, IMessage, IEquatable<NewTowerTaskDataUpdateNotify>, IDeepCloneable<NewTowerTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600FB1B RID: 64283 RVA: 0x002497D5 File Offset: 0x002479D5
		[NullableContext(1)]
		public static NewTowerTaskDataUpdateNotify Create()
		{
			return new NewTowerTaskDataUpdateNotify();
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600FB1C RID: 64284 RVA: 0x002497DC File Offset: 0x002479DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600FB1D RID: 64285 RVA: 0x002497DF File Offset: 0x002479DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600FB1E RID: 64286 RVA: 0x002497E6 File Offset: 0x002479E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600FB1F RID: 64287 RVA: 0x002497F9 File Offset: 0x002479F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTaskDataUpdateNotify(NewTowerTaskDataUpdateNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB20 RID: 64288 RVA: 0x00249823 File Offset: 0x00247A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTaskDataUpdateNotify Clone()
		{
			return new NewTowerTaskDataUpdateNotify(this);
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600FB21 RID: 64289 RVA: 0x0024982B File Offset: 0x00247A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x0600FB22 RID: 64290 RVA: 0x00249833 File Offset: 0x00247A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerTaskDataUpdateNotify);
		}

		// Token: 0x0600FB23 RID: 64291 RVA: 0x00249841 File Offset: 0x00247A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB24 RID: 64292 RVA: 0x00249874 File Offset: 0x00247A74
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

		// Token: 0x0600FB25 RID: 64293 RVA: 0x002498A8 File Offset: 0x00247AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB26 RID: 64294 RVA: 0x002498B5 File Offset: 0x00247AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB27 RID: 64295 RVA: 0x002498BE File Offset: 0x00247ABE
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

		// Token: 0x0600FB28 RID: 64296 RVA: 0x002498E8 File Offset: 0x00247AE8
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

		// Token: 0x0600FB29 RID: 64297 RVA: 0x00249921 File Offset: 0x00247B21
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

		// Token: 0x0600FB2A RID: 64298 RVA: 0x0024994F File Offset: 0x00247B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB2B RID: 64299 RVA: 0x00249958 File Offset: 0x00247B58
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, NewTowerTaskDataUpdateNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x0400646C RID: 25708
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400646D RID: 25709
		public const int ActivityTasksFieldNumber = 5;

		// Token: 0x0400646E RID: 25710
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(42U, ActivityTask.Parser);

		// Token: 0x0400646F RID: 25711
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
