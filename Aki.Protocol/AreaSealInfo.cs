using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010C RID: 268
	public sealed class AreaSealInfo : IMessage<AreaSealInfo>, IMessage, IEquatable<AreaSealInfo>, IDeepCloneable<AreaSealInfo>, IBufferMessage
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x0006364C File Offset: 0x0006184C
		[NullableContext(1)]
		public static AreaSealInfo Create()
		{
			return new AreaSealInfo();
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x00063653 File Offset: 0x00061853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaSealInfo> Parser
		{
			get
			{
				return AreaSealInfo._parser;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x0006365A File Offset: 0x0006185A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x0006365D File Offset: 0x0006185D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaSealInfo.Descriptor;
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00063664 File Offset: 0x00061864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaSealInfo()
		{
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0006366C File Offset: 0x0006186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaSealInfo(AreaSealInfo other) : this()
		{
			this.uId_ = other.uId_;
			this.areaType_ = other.areaType_;
			this.isSeal_ = other.isSeal_;
			this.unLockRound_ = other.unLockRound_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000636C0 File Offset: 0x000618C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaSealInfo Clone()
		{
			return new AreaSealInfo(this);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000636C8 File Offset: 0x000618C8
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x000636D0 File Offset: 0x000618D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UId
		{
			get
			{
				return this.uId_;
			}
			set
			{
				this.uId_ = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000636D9 File Offset: 0x000618D9
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x000636E1 File Offset: 0x000618E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAreaType AreaType
		{
			get
			{
				return this.areaType_;
			}
			set
			{
				this.areaType_ = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x000636EA File Offset: 0x000618EA
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x000636F2 File Offset: 0x000618F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSeal
		{
			get
			{
				return this.isSeal_;
			}
			set
			{
				this.isSeal_ = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000636FB File Offset: 0x000618FB
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x00063703 File Offset: 0x00061903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockRound
		{
			get
			{
				return this.unLockRound_;
			}
			set
			{
				this.unLockRound_ = value;
			}
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x0006370C File Offset: 0x0006190C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaSealInfo);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x0006371C File Offset: 0x0006191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaSealInfo other)
		{
			return other != null && (other == this || (this.UId == other.UId && this.AreaType == other.AreaType && this.IsSeal == other.IsSeal && this.UnLockRound == other.UnLockRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00063788 File Offset: 0x00061988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UId != 0)
			{
				num ^= this.UId.GetHashCode();
			}
			if (this.AreaType != BattleAreaType.Retrieve)
			{
				num ^= this.AreaType.GetHashCode();
			}
			if (this.IsSeal)
			{
				num ^= this.IsSeal.GetHashCode();
			}
			if (this.UnLockRound != 0)
			{
				num ^= this.UnLockRound.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00063818 File Offset: 0x00061A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00063825 File Offset: 0x00061A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00063830 File Offset: 0x00061A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UId);
			}
			if (this.AreaType != BattleAreaType.Retrieve)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.AreaType);
			}
			if (this.IsSeal)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSeal);
			}
			if (this.UnLockRound != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UnLockRound);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000638C0 File Offset: 0x00061AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UId);
			}
			if (this.AreaType != BattleAreaType.Retrieve)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AreaType);
			}
			if (this.IsSeal)
			{
				num += 2;
			}
			if (this.UnLockRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockRound);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0006393C File Offset: 0x00061B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaSealInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UId != 0)
			{
				this.UId = other.UId;
			}
			if (other.AreaType != BattleAreaType.Retrieve)
			{
				this.AreaType = other.AreaType;
			}
			if (other.IsSeal)
			{
				this.IsSeal = other.IsSeal;
			}
			if (other.UnLockRound != 0)
			{
				this.UnLockRound = other.UnLockRound;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000639B4 File Offset: 0x00061BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000639C0 File Offset: 0x00061BC0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.UId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.AreaType = (BattleAreaType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsSeal = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.UnLockRound = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025B5 RID: 9653
		private static readonly MessageParser<AreaSealInfo> _parser = new MessageParser<AreaSealInfo>(() => new AreaSealInfo());

		// Token: 0x040025B6 RID: 9654
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025B7 RID: 9655
		public const int UIdFieldNumber = 1;

		// Token: 0x040025B8 RID: 9656
		private int uId_;

		// Token: 0x040025B9 RID: 9657
		public const int AreaTypeFieldNumber = 2;

		// Token: 0x040025BA RID: 9658
		private BattleAreaType areaType_;

		// Token: 0x040025BB RID: 9659
		public const int IsSealFieldNumber = 3;

		// Token: 0x040025BC RID: 9660
		private bool isSeal_;

		// Token: 0x040025BD RID: 9661
		public const int UnLockRoundFieldNumber = 4;

		// Token: 0x040025BE RID: 9662
		private int unLockRound_;
	}
}
