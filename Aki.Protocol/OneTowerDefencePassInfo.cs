using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B93 RID: 2963
	public sealed class OneTowerDefencePassInfo : IMessage<OneTowerDefencePassInfo>, IMessage, IEquatable<OneTowerDefencePassInfo>, IDeepCloneable<OneTowerDefencePassInfo>, IBufferMessage
	{
		// Token: 0x0601010A RID: 65802 RVA: 0x00258430 File Offset: 0x00256630
		[NullableContext(1)]
		public static OneTowerDefencePassInfo Create()
		{
			return new OneTowerDefencePassInfo();
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0601010B RID: 65803 RVA: 0x00258437 File Offset: 0x00256637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneTowerDefencePassInfo> Parser
		{
			get
			{
				return OneTowerDefencePassInfo._parser;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0601010C RID: 65804 RVA: 0x0025843E File Offset: 0x0025663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0601010D RID: 65805 RVA: 0x00258441 File Offset: 0x00256641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneTowerDefencePassInfo.Descriptor;
			}
		}

		// Token: 0x0601010E RID: 65806 RVA: 0x00258448 File Offset: 0x00256648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTowerDefencePassInfo()
		{
		}

		// Token: 0x0601010F RID: 65807 RVA: 0x00258450 File Offset: 0x00256650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTowerDefencePassInfo(OneTowerDefencePassInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isSingle_ = other.isSingle_;
			this.passInfo_ = ((other.passInfo_ != null) ? other.passInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010110 RID: 65808 RVA: 0x002584A8 File Offset: 0x002566A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTowerDefencePassInfo Clone()
		{
			return new OneTowerDefencePassInfo(this);
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x06010111 RID: 65809 RVA: 0x002584B0 File Offset: 0x002566B0
		// (set) Token: 0x06010112 RID: 65810 RVA: 0x002584B8 File Offset: 0x002566B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x06010113 RID: 65811 RVA: 0x002584C1 File Offset: 0x002566C1
		// (set) Token: 0x06010114 RID: 65812 RVA: 0x002584C9 File Offset: 0x002566C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSingle
		{
			get
			{
				return this.isSingle_;
			}
			set
			{
				this.isSingle_ = value;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x06010115 RID: 65813 RVA: 0x002584D2 File Offset: 0x002566D2
		// (set) Token: 0x06010116 RID: 65814 RVA: 0x002584DA File Offset: 0x002566DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassInfo PassInfo
		{
			get
			{
				return this.passInfo_;
			}
			set
			{
				this.passInfo_ = value;
			}
		}

		// Token: 0x06010117 RID: 65815 RVA: 0x002584E3 File Offset: 0x002566E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneTowerDefencePassInfo);
		}

		// Token: 0x06010118 RID: 65816 RVA: 0x002584F4 File Offset: 0x002566F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneTowerDefencePassInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsSingle == other.IsSingle && object.Equals(this.PassInfo, other.PassInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010119 RID: 65817 RVA: 0x00258554 File Offset: 0x00256754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsSingle)
			{
				num ^= this.IsSingle.GetHashCode();
			}
			if (this.passInfo_ != null)
			{
				num ^= this.PassInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601011A RID: 65818 RVA: 0x002585C2 File Offset: 0x002567C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601011B RID: 65819 RVA: 0x002585CF File Offset: 0x002567CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601011C RID: 65820 RVA: 0x002585D8 File Offset: 0x002567D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.IsSingle)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSingle);
			}
			if (this.passInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PassInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601011D RID: 65821 RVA: 0x0025864C File Offset: 0x0025684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.IsSingle)
			{
				num += 2;
			}
			if (this.passInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PassInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601011E RID: 65822 RVA: 0x002586B0 File Offset: 0x002568B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneTowerDefencePassInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsSingle)
			{
				this.IsSingle = other.IsSingle;
			}
			if (other.passInfo_ != null)
			{
				if (this.passInfo_ == null)
				{
					this.PassInfo = new TowerDefencePassInfo();
				}
				this.PassInfo.MergeFrom(other.PassInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601011F RID: 65823 RVA: 0x0025872C File Offset: 0x0025692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010120 RID: 65824 RVA: 0x00258738 File Offset: 0x00256938
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.passInfo_ == null)
							{
								this.PassInfo = new TowerDefencePassInfo();
							}
							input.ReadMessage(this.PassInfo);
						}
					}
					else
					{
						this.IsSingle = input.ReadBool();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400666C RID: 26220
		private static readonly MessageParser<OneTowerDefencePassInfo> _parser = new MessageParser<OneTowerDefencePassInfo>(() => new OneTowerDefencePassInfo());

		// Token: 0x0400666D RID: 26221
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400666E RID: 26222
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400666F RID: 26223
		private int challengeId_;

		// Token: 0x04006670 RID: 26224
		public const int IsSingleFieldNumber = 2;

		// Token: 0x04006671 RID: 26225
		private bool isSingle_;

		// Token: 0x04006672 RID: 26226
		public const int PassInfoFieldNumber = 3;

		// Token: 0x04006673 RID: 26227
		private TowerDefencePassInfo passInfo_;
	}
}
