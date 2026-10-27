using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001085 RID: 4229
	public sealed class RoleIllustratedInfo : IMessage<RoleIllustratedInfo>, IMessage, IEquatable<RoleIllustratedInfo>, IDeepCloneable<RoleIllustratedInfo>, IBufferMessage
	{
		// Token: 0x06016968 RID: 92520 RVA: 0x003482FB File Offset: 0x003464FB
		[NullableContext(1)]
		public static RoleIllustratedInfo Create()
		{
			return new RoleIllustratedInfo();
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x06016969 RID: 92521 RVA: 0x00348302 File Offset: 0x00346502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleIllustratedInfo> Parser
		{
			get
			{
				return RoleIllustratedInfo._parser;
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x0601696A RID: 92522 RVA: 0x00348309 File Offset: 0x00346509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x0601696B RID: 92523 RVA: 0x0034830C File Offset: 0x0034650C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x0601696C RID: 92524 RVA: 0x00348313 File Offset: 0x00346513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfo()
		{
		}

		// Token: 0x0601696D RID: 92525 RVA: 0x0034831B File Offset: 0x0034651B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfo(RoleIllustratedInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601696E RID: 92526 RVA: 0x0034834C File Offset: 0x0034654C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfo Clone()
		{
			return new RoleIllustratedInfo(this);
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x0601696F RID: 92527 RVA: 0x00348354 File Offset: 0x00346554
		// (set) Token: 0x06016970 RID: 92528 RVA: 0x0034835C File Offset: 0x0034655C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x06016971 RID: 92529 RVA: 0x00348365 File Offset: 0x00346565
		// (set) Token: 0x06016972 RID: 92530 RVA: 0x0034836D File Offset: 0x0034656D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x06016973 RID: 92531 RVA: 0x00348376 File Offset: 0x00346576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleIllustratedInfo);
		}

		// Token: 0x06016974 RID: 92532 RVA: 0x00348384 File Offset: 0x00346584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleIllustratedInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016975 RID: 92533 RVA: 0x003483C4 File Offset: 0x003465C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016976 RID: 92534 RVA: 0x0034841C File Offset: 0x0034661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016977 RID: 92535 RVA: 0x00348429 File Offset: 0x00346629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016978 RID: 92536 RVA: 0x00348434 File Offset: 0x00346634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016979 RID: 92537 RVA: 0x0034848C File Offset: 0x0034668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601697A RID: 92538 RVA: 0x003484E4 File Offset: 0x003466E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601697B RID: 92539 RVA: 0x00348534 File Offset: 0x00346734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601697C RID: 92540 RVA: 0x00348540 File Offset: 0x00346740
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086E9 RID: 34537
		private static readonly MessageParser<RoleIllustratedInfo> _parser = new MessageParser<RoleIllustratedInfo>(() => new RoleIllustratedInfo());

		// Token: 0x040086EA RID: 34538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086EB RID: 34539
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086EC RID: 34540
		private int roleId_;

		// Token: 0x040086ED RID: 34541
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x040086EE RID: 34542
		private long unlockTime_;
	}
}
