using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C76 RID: 3190
	public sealed class PhantomBattleDebugCardInfo : IMessage<PhantomBattleDebugCardInfo>, IMessage, IEquatable<PhantomBattleDebugCardInfo>, IDeepCloneable<PhantomBattleDebugCardInfo>, IBufferMessage
	{
		// Token: 0x060114AC RID: 70828 RVA: 0x0028819E File Offset: 0x0028639E
		[NullableContext(1)]
		public static PhantomBattleDebugCardInfo Create()
		{
			return new PhantomBattleDebugCardInfo();
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x060114AD RID: 70829 RVA: 0x002881A5 File Offset: 0x002863A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugCardInfo> Parser
		{
			get
			{
				return PhantomBattleDebugCardInfo._parser;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x060114AE RID: 70830 RVA: 0x002881AC File Offset: 0x002863AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x060114AF RID: 70831 RVA: 0x002881AF File Offset: 0x002863AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugCardInfo.Descriptor;
			}
		}

		// Token: 0x060114B0 RID: 70832 RVA: 0x002881B6 File Offset: 0x002863B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugCardInfo()
		{
		}

		// Token: 0x060114B1 RID: 70833 RVA: 0x002881C0 File Offset: 0x002863C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugCardInfo(PhantomBattleDebugCardInfo other) : this()
		{
			this.phantomBattleHandCardInfo_ = ((other.phantomBattleHandCardInfo_ != null) ? other.phantomBattleHandCardInfo_.Clone() : null);
			this.fightPower_ = other.fightPower_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060114B2 RID: 70834 RVA: 0x0028820C File Offset: 0x0028640C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugCardInfo Clone()
		{
			return new PhantomBattleDebugCardInfo(this);
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x060114B3 RID: 70835 RVA: 0x00288214 File Offset: 0x00286414
		// (set) Token: 0x060114B4 RID: 70836 RVA: 0x0028821C File Offset: 0x0028641C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
			set
			{
				this.phantomBattleHandCardInfo_ = value;
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x060114B5 RID: 70837 RVA: 0x00288225 File Offset: 0x00286425
		// (set) Token: 0x060114B6 RID: 70838 RVA: 0x0028822D File Offset: 0x0028642D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightPower
		{
			get
			{
				return this.fightPower_;
			}
			set
			{
				this.fightPower_ = value;
			}
		}

		// Token: 0x060114B7 RID: 70839 RVA: 0x00288236 File Offset: 0x00286436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugCardInfo);
		}

		// Token: 0x060114B8 RID: 70840 RVA: 0x00288244 File Offset: 0x00286444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugCardInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleHandCardInfo, other.PhantomBattleHandCardInfo) && this.FightPower == other.FightPower && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114B9 RID: 70841 RVA: 0x00288294 File Offset: 0x00286494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num ^= this.PhantomBattleHandCardInfo.GetHashCode();
			}
			if (this.FightPower != 0)
			{
				num ^= this.FightPower.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060114BA RID: 70842 RVA: 0x002882E9 File Offset: 0x002864E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114BB RID: 70843 RVA: 0x002882F6 File Offset: 0x002864F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114BC RID: 70844 RVA: 0x00288300 File Offset: 0x00286500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleHandCardInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleHandCardInfo);
			}
			if (this.FightPower != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FightPower);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114BD RID: 70845 RVA: 0x0028835C File Offset: 0x0028655C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleHandCardInfo);
			}
			if (this.FightPower != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightPower);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060114BE RID: 70846 RVA: 0x002883B4 File Offset: 0x002865B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleHandCardInfo_ != null)
			{
				if (this.phantomBattleHandCardInfo_ == null)
				{
					this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
				}
				this.PhantomBattleHandCardInfo.MergeFrom(other.PhantomBattleHandCardInfo);
			}
			if (other.FightPower != 0)
			{
				this.FightPower = other.FightPower;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060114BF RID: 70847 RVA: 0x0028841C File Offset: 0x0028661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114C0 RID: 70848 RVA: 0x00288428 File Offset: 0x00286628
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FightPower = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomBattleHandCardInfo_ == null)
					{
						this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
					}
					input.ReadMessage(this.PhantomBattleHandCardInfo);
				}
			}
		}

		// Token: 0x04006D54 RID: 27988
		private static readonly MessageParser<PhantomBattleDebugCardInfo> _parser = new MessageParser<PhantomBattleDebugCardInfo>(() => new PhantomBattleDebugCardInfo());

		// Token: 0x04006D55 RID: 27989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D56 RID: 27990
		public const int PhantomBattleHandCardInfoFieldNumber = 1;

		// Token: 0x04006D57 RID: 27991
		private PhantomBattleHandCardInfo phantomBattleHandCardInfo_;

		// Token: 0x04006D58 RID: 27992
		public const int FightPowerFieldNumber = 2;

		// Token: 0x04006D59 RID: 27993
		private int fightPower_;
	}
}
