using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006A RID: 106
	[NetMessage(EMessageId.ActionFinishImmediatelyNotify)]
	public sealed class ActionFinishImmediatelyNotify : IMessage<ActionFinishImmediatelyNotify>, IMessage, IEquatable<ActionFinishImmediatelyNotify>, IDeepCloneable<ActionFinishImmediatelyNotify>, IBufferMessage
	{
		// Token: 0x060016DA RID: 5850 RVA: 0x0003BDCB File Offset: 0x00039FCB
		[NullableContext(1)]
		public static ActionFinishImmediatelyNotify Create()
		{
			return new ActionFinishImmediatelyNotify();
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x0003BDD2 File Offset: 0x00039FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x0003BDD5 File Offset: 0x00039FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionFinishImmediatelyNotify.Descriptor;
			}
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0003BDDC File Offset: 0x00039FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishImmediatelyNotify()
		{
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0003BDE4 File Offset: 0x00039FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishImmediatelyNotify(ActionFinishImmediatelyNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0003BE15 File Offset: 0x0003A015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishImmediatelyNotify Clone()
		{
			return new ActionFinishImmediatelyNotify(this);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0003BE1D File Offset: 0x0003A01D
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0003BE25 File Offset: 0x0003A025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0003BE2E File Offset: 0x0003A02E
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0003BE36 File Offset: 0x0003A036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0003BE3F File Offset: 0x0003A03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionFinishImmediatelyNotify);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0003BE4D File Offset: 0x0003A04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionFinishImmediatelyNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0003BE8C File Offset: 0x0003A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0003BEE4 File Offset: 0x0003A0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0003BEF1 File Offset: 0x0003A0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0003BEFC File Offset: 0x0003A0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0003BF58 File Offset: 0x0003A158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionFinishImmediatelyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0003C000 File Offset: 0x0003A200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0003C00C File Offset: 0x0003A20C
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040020FF RID: 8447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002100 RID: 8448
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04002101 RID: 8449
		private int playerId_;

		// Token: 0x04002102 RID: 8450
		public const int IncIdFieldNumber = 9;

		// Token: 0x04002103 RID: 8451
		private int incId_;
	}
}
