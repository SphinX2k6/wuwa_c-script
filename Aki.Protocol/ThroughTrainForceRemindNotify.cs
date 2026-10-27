using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001364 RID: 4964
	[NetMessage(EMessageId.ThroughTrainForceRemindNotify)]
	public sealed class ThroughTrainForceRemindNotify : IMessage<ThroughTrainForceRemindNotify>, IMessage, IEquatable<ThroughTrainForceRemindNotify>, IDeepCloneable<ThroughTrainForceRemindNotify>, IBufferMessage
	{
		// Token: 0x0601A5CF RID: 107983 RVA: 0x003D40A9 File Offset: 0x003D22A9
		[NullableContext(1)]
		public static ThroughTrainForceRemindNotify Create()
		{
			return new ThroughTrainForceRemindNotify();
		}

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x0601A5D0 RID: 107984 RVA: 0x003D40B0 File Offset: 0x003D22B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x0601A5D1 RID: 107985 RVA: 0x003D40B3 File Offset: 0x003D22B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainForceRemindNotify.Descriptor;
			}
		}

		// Token: 0x0601A5D2 RID: 107986 RVA: 0x003D40BA File Offset: 0x003D22BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainForceRemindNotify()
		{
		}

		// Token: 0x0601A5D3 RID: 107987 RVA: 0x003D40C2 File Offset: 0x003D22C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainForceRemindNotify(ThroughTrainForceRemindNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5D4 RID: 107988 RVA: 0x003D40E7 File Offset: 0x003D22E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainForceRemindNotify Clone()
		{
			return new ThroughTrainForceRemindNotify(this);
		}

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x0601A5D5 RID: 107989 RVA: 0x003D40EF File Offset: 0x003D22EF
		// (set) Token: 0x0601A5D6 RID: 107990 RVA: 0x003D40F7 File Offset: 0x003D22F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0601A5D7 RID: 107991 RVA: 0x003D4100 File Offset: 0x003D2300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainForceRemindNotify);
		}

		// Token: 0x0601A5D8 RID: 107992 RVA: 0x003D410E File Offset: 0x003D230E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainForceRemindNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5D9 RID: 107993 RVA: 0x003D413C File Offset: 0x003D233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A5DA RID: 107994 RVA: 0x003D417B File Offset: 0x003D237B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5DB RID: 107995 RVA: 0x003D4188 File Offset: 0x003D2388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5DC RID: 107996 RVA: 0x003D4191 File Offset: 0x003D2391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5DD RID: 107997 RVA: 0x003D41C4 File Offset: 0x003D23C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A5DE RID: 107998 RVA: 0x003D4202 File Offset: 0x003D2402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainForceRemindNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A5DF RID: 107999 RVA: 0x003D4233 File Offset: 0x003D2433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5E0 RID: 108000 RVA: 0x003D423C File Offset: 0x003D243C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009998 RID: 39320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009999 RID: 39321
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x0400999A RID: 39322
		private int activityId_;
	}
}
