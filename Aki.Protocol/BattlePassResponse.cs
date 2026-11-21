using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000174 RID: 372
	[NetMessage(EMessageId.BattlePassResponse)]
	public sealed class BattlePassResponse : IMessage<BattlePassResponse>, IMessage, IEquatable<BattlePassResponse>, IDeepCloneable<BattlePassResponse>, IBufferMessage
	{
		// Token: 0x06002DD7 RID: 11735 RVA: 0x00076A9E File Offset: 0x00074C9E
		[NullableContext(1)]
		public static BattlePassResponse Create()
		{
			return new BattlePassResponse();
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x00076AA5 File Offset: 0x00074CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x00076AA8 File Offset: 0x00074CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassResponse.Descriptor;
			}
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00076AAF File Offset: 0x00074CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassResponse()
		{
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00076AB8 File Offset: 0x00074CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassResponse(BattlePassResponse other) : this()
		{
			this.battlePass_ = ((other.battlePass_ != null) ? other.battlePass_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00076B04 File Offset: 0x00074D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassResponse Clone()
		{
			return new BattlePassResponse(this);
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x00076B0C File Offset: 0x00074D0C
		// (set) Token: 0x06002DDE RID: 11742 RVA: 0x00076B14 File Offset: 0x00074D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass BattlePass
		{
			get
			{
				return this.battlePass_;
			}
			set
			{
				this.battlePass_ = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x00076B1D File Offset: 0x00074D1D
		// (set) Token: 0x06002DE0 RID: 11744 RVA: 0x00076B25 File Offset: 0x00074D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00076B2E File Offset: 0x00074D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassResponse);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00076B3C File Offset: 0x00074D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassResponse other)
		{
			return other != null && (other == this || (object.Equals(this.BattlePass, other.BattlePass) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00076B8C File Offset: 0x00074D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battlePass_ != null)
			{
				num ^= this.BattlePass.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00076BE7 File Offset: 0x00074DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00076BF4 File Offset: 0x00074DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00076C00 File Offset: 0x00074E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battlePass_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BattlePass);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00076C5C File Offset: 0x00074E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battlePass_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattlePass);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00076CB4 File Offset: 0x00074EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battlePass_ != null)
			{
				if (this.battlePass_ == null)
				{
					this.BattlePass = new PbBattlePass();
				}
				this.BattlePass.MergeFrom(other.BattlePass);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00076D1C File Offset: 0x00074F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00076D28 File Offset: 0x00074F28
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
				if (num != 18U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.battlePass_ == null)
					{
						this.BattlePass = new PbBattlePass();
					}
					input.ReadMessage(this.BattlePass);
				}
			}
		}

		// Token: 0x040028A3 RID: 10403
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A4 RID: 10404
		public const int BattlePassFieldNumber = 2;

		// Token: 0x040028A5 RID: 10405
		private PbBattlePass battlePass_;

		// Token: 0x040028A6 RID: 10406
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040028A7 RID: 10407
		private ErrorCode errorCode_;
	}
}
