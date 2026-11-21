using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7B RID: 3963
	[NetMessage(EMessageId.RogueInstExtraInfoUpdateNotify)]
	public sealed class RogueInstExtraInfoUpdateNotify : IMessage<RogueInstExtraInfoUpdateNotify>, IMessage, IEquatable<RogueInstExtraInfoUpdateNotify>, IDeepCloneable<RogueInstExtraInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601538E RID: 86926 RVA: 0x00314D03 File Offset: 0x00312F03
		[NullableContext(1)]
		public static RogueInstExtraInfoUpdateNotify Create()
		{
			return new RogueInstExtraInfoUpdateNotify();
		}

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x0601538F RID: 86927 RVA: 0x00314D0A File Offset: 0x00312F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x06015390 RID: 86928 RVA: 0x00314D0D File Offset: 0x00312F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015391 RID: 86929 RVA: 0x00314D14 File Offset: 0x00312F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoUpdateNotify()
		{
		}

		// Token: 0x06015392 RID: 86930 RVA: 0x00314D1C File Offset: 0x00312F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoUpdateNotify(RogueInstExtraInfoUpdateNotify other) : this()
		{
			this.rogueInstExtraInfo_ = ((other.rogueInstExtraInfo_ != null) ? other.rogueInstExtraInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015393 RID: 86931 RVA: 0x00314D51 File Offset: 0x00312F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoUpdateNotify Clone()
		{
			return new RogueInstExtraInfoUpdateNotify(this);
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x06015394 RID: 86932 RVA: 0x00314D59 File Offset: 0x00312F59
		// (set) Token: 0x06015395 RID: 86933 RVA: 0x00314D61 File Offset: 0x00312F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo RogueInstExtraInfo
		{
			get
			{
				return this.rogueInstExtraInfo_;
			}
			set
			{
				this.rogueInstExtraInfo_ = value;
			}
		}

		// Token: 0x06015396 RID: 86934 RVA: 0x00314D6A File Offset: 0x00312F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfoUpdateNotify);
		}

		// Token: 0x06015397 RID: 86935 RVA: 0x00314D78 File Offset: 0x00312F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueInstExtraInfo, other.RogueInstExtraInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015398 RID: 86936 RVA: 0x00314DAC File Offset: 0x00312FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueInstExtraInfo_ != null)
			{
				num ^= this.RogueInstExtraInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015399 RID: 86937 RVA: 0x00314DE8 File Offset: 0x00312FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601539A RID: 86938 RVA: 0x00314DF5 File Offset: 0x00312FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601539B RID: 86939 RVA: 0x00314DFE File Offset: 0x00312FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueInstExtraInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueInstExtraInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601539C RID: 86940 RVA: 0x00314E30 File Offset: 0x00313030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueInstExtraInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueInstExtraInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601539D RID: 86941 RVA: 0x00314E70 File Offset: 0x00313070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstExtraInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueInstExtraInfo_ != null)
			{
				if (this.rogueInstExtraInfo_ == null)
				{
					this.RogueInstExtraInfo = new RogueInstExtraInfo();
				}
				this.RogueInstExtraInfo.MergeFrom(other.RogueInstExtraInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601539E RID: 86942 RVA: 0x00314EC4 File Offset: 0x003130C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601539F RID: 86943 RVA: 0x00314ED0 File Offset: 0x003130D0
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueInstExtraInfo_ == null)
					{
						this.RogueInstExtraInfo = new RogueInstExtraInfo();
					}
					input.ReadMessage(this.RogueInstExtraInfo);
				}
			}
		}

		// Token: 0x0400802D RID: 32813
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400802E RID: 32814
		public const int RogueInstExtraInfoFieldNumber = 10;

		// Token: 0x0400802F RID: 32815
		private RogueInstExtraInfo rogueInstExtraInfo_;
	}
}
