using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014A RID: 330
	[NetMessage(EMessageId.BabelActivityTaskInfoNotify)]
	public sealed class BabelActivityTaskInfoNotify : IMessage<BabelActivityTaskInfoNotify>, IMessage, IEquatable<BabelActivityTaskInfoNotify>, IDeepCloneable<BabelActivityTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x06002A9B RID: 10907 RVA: 0x00070020 File Offset: 0x0006E220
		[NullableContext(1)]
		public static BabelActivityTaskInfoNotify Create()
		{
			return new BabelActivityTaskInfoNotify();
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x00070027 File Offset: 0x0006E227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x0007002A File Offset: 0x0006E22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00070031 File Offset: 0x0006E231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityTaskInfoNotify()
		{
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00070044 File Offset: 0x0006E244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityTaskInfoNotify(BabelActivityTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0007006E File Offset: 0x0006E26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityTaskInfoNotify Clone()
		{
			return new BabelActivityTaskInfoNotify(this);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x00070076 File Offset: 0x0006E276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0007007E File Offset: 0x0006E27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityTaskInfoNotify);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0007008C File Offset: 0x0006E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityTaskInfoNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000700C0 File Offset: 0x0006E2C0
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

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000700F4 File Offset: 0x0006E2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00070101 File Offset: 0x0006E301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0007010A File Offset: 0x0006E30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, BabelActivityTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00070134 File Offset: 0x0006E334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(BabelActivityTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0007016D File Offset: 0x0006E36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0007019B File Offset: 0x0006E39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000701A4 File Offset: 0x0006E3A4
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, BabelActivityTaskInfoNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x040027C6 RID: 10182
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027C7 RID: 10183
		public const int ActivityTasksFieldNumber = 3;

		// Token: 0x040027C8 RID: 10184
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(26U, ActivityTask.Parser);

		// Token: 0x040027C9 RID: 10185
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
