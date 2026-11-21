using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010E RID: 270
	public sealed class AreaSealInfo : IMessage<AreaSealInfo>, IMessage, IEquatable<AreaSealInfo>, IDeepCloneable<AreaSealInfo>, IBufferMessage
	{
		// Token: 0x06002595 RID: 9621 RVA: 0x00064670 File Offset: 0x00062870
		[NullableContext(1)]
		public static AreaSealInfo Create()
		{
			return new AreaSealInfo();
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00064677 File Offset: 0x00062877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaSealInfo> Parser
		{
			get
			{
				return AreaSealInfo._parser;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x0006467E File Offset: 0x0006287E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x00064681 File Offset: 0x00062881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaSealInfo.Descriptor;
			}
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00064688 File Offset: 0x00062888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaSealInfo()
		{
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00064690 File Offset: 0x00062890
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

		// Token: 0x0600259B RID: 9627 RVA: 0x000646E4 File Offset: 0x000628E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaSealInfo Clone()
		{
			return new AreaSealInfo(this);
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000646EC File Offset: 0x000628EC
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x000646F4 File Offset: 0x000628F4
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000646FD File Offset: 0x000628FD
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x00064705 File Offset: 0x00062905
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0006470E File Offset: 0x0006290E
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x00064716 File Offset: 0x00062916
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0006471F File Offset: 0x0006291F
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x00064727 File Offset: 0x00062927
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

		// Token: 0x060025A4 RID: 9636 RVA: 0x00064730 File Offset: 0x00062930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaSealInfo);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00064740 File Offset: 0x00062940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaSealInfo other)
		{
			return other != null && (other == this || (this.UId == other.UId && this.AreaType == other.AreaType && this.IsSeal == other.IsSeal && this.UnLockRound == other.UnLockRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000647AC File Offset: 0x000629AC
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

		// Token: 0x060025A7 RID: 9639 RVA: 0x0006483C File Offset: 0x00062A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00064849 File Offset: 0x00062A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00064854 File Offset: 0x00062A54
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

		// Token: 0x060025AA RID: 9642 RVA: 0x000648E4 File Offset: 0x00062AE4
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

		// Token: 0x060025AB RID: 9643 RVA: 0x00064960 File Offset: 0x00062B60
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

		// Token: 0x060025AC RID: 9644 RVA: 0x000649D8 File Offset: 0x00062BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000649E4 File Offset: 0x00062BE4
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

		// Token: 0x04002620 RID: 9760
		private static readonly MessageParser<AreaSealInfo> _parser = new MessageParser<AreaSealInfo>(() => new AreaSealInfo());

		// Token: 0x04002621 RID: 9761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002622 RID: 9762
		public const int UIdFieldNumber = 1;

		// Token: 0x04002623 RID: 9763
		private int uId_;

		// Token: 0x04002624 RID: 9764
		public const int AreaTypeFieldNumber = 2;

		// Token: 0x04002625 RID: 9765
		private BattleAreaType areaType_;

		// Token: 0x04002626 RID: 9766
		public const int IsSealFieldNumber = 3;

		// Token: 0x04002627 RID: 9767
		private bool isSeal_;

		// Token: 0x04002628 RID: 9768
		public const int UnLockRoundFieldNumber = 4;

		// Token: 0x04002629 RID: 9769
		private int unLockRound_;
	}
}
