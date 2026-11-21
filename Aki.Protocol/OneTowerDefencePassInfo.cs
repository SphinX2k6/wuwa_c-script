using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B83 RID: 2947
	public sealed class OneTowerDefencePassInfo : IMessage<OneTowerDefencePassInfo>, IMessage, IEquatable<OneTowerDefencePassInfo>, IDeepCloneable<OneTowerDefencePassInfo>, IBufferMessage
	{
		// Token: 0x06010006 RID: 65542 RVA: 0x00256560 File Offset: 0x00254760
		[NullableContext(1)]
		public static OneTowerDefencePassInfo Create()
		{
			return new OneTowerDefencePassInfo();
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x06010007 RID: 65543 RVA: 0x00256567 File Offset: 0x00254767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneTowerDefencePassInfo> Parser
		{
			get
			{
				return OneTowerDefencePassInfo._parser;
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x06010008 RID: 65544 RVA: 0x0025656E File Offset: 0x0025476E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x06010009 RID: 65545 RVA: 0x00256571 File Offset: 0x00254771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneTowerDefencePassInfo.Descriptor;
			}
		}

		// Token: 0x0601000A RID: 65546 RVA: 0x00256578 File Offset: 0x00254778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTowerDefencePassInfo()
		{
		}

		// Token: 0x0601000B RID: 65547 RVA: 0x00256580 File Offset: 0x00254780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTowerDefencePassInfo(OneTowerDefencePassInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isSingle_ = other.isSingle_;
			this.passInfo_ = ((other.passInfo_ != null) ? other.passInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601000C RID: 65548 RVA: 0x002565D8 File Offset: 0x002547D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTowerDefencePassInfo Clone()
		{
			return new OneTowerDefencePassInfo(this);
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0601000D RID: 65549 RVA: 0x002565E0 File Offset: 0x002547E0
		// (set) Token: 0x0601000E RID: 65550 RVA: 0x002565E8 File Offset: 0x002547E8
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

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0601000F RID: 65551 RVA: 0x002565F1 File Offset: 0x002547F1
		// (set) Token: 0x06010010 RID: 65552 RVA: 0x002565F9 File Offset: 0x002547F9
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

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x06010011 RID: 65553 RVA: 0x00256602 File Offset: 0x00254802
		// (set) Token: 0x06010012 RID: 65554 RVA: 0x0025660A File Offset: 0x0025480A
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

		// Token: 0x06010013 RID: 65555 RVA: 0x00256613 File Offset: 0x00254813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneTowerDefencePassInfo);
		}

		// Token: 0x06010014 RID: 65556 RVA: 0x00256624 File Offset: 0x00254824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneTowerDefencePassInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsSingle == other.IsSingle && object.Equals(this.PassInfo, other.PassInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010015 RID: 65557 RVA: 0x00256684 File Offset: 0x00254884
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

		// Token: 0x06010016 RID: 65558 RVA: 0x002566F2 File Offset: 0x002548F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010017 RID: 65559 RVA: 0x002566FF File Offset: 0x002548FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010018 RID: 65560 RVA: 0x00256708 File Offset: 0x00254908
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

		// Token: 0x06010019 RID: 65561 RVA: 0x0025677C File Offset: 0x0025497C
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

		// Token: 0x0601001A RID: 65562 RVA: 0x002567E0 File Offset: 0x002549E0
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

		// Token: 0x0601001B RID: 65563 RVA: 0x0025685C File Offset: 0x00254A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601001C RID: 65564 RVA: 0x00256868 File Offset: 0x00254A68
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

		// Token: 0x0400667C RID: 26236
		private static readonly MessageParser<OneTowerDefencePassInfo> _parser = new MessageParser<OneTowerDefencePassInfo>(() => new OneTowerDefencePassInfo());

		// Token: 0x0400667D RID: 26237
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400667E RID: 26238
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400667F RID: 26239
		private int challengeId_;

		// Token: 0x04006680 RID: 26240
		public const int IsSingleFieldNumber = 2;

		// Token: 0x04006681 RID: 26241
		private bool isSingle_;

		// Token: 0x04006682 RID: 26242
		public const int PassInfoFieldNumber = 3;

		// Token: 0x04006683 RID: 26243
		private TowerDefencePassInfo passInfo_;
	}
}
