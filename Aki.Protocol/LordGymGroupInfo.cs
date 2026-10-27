using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095E RID: 2398
	public sealed class LordGymGroupInfo : IMessage<LordGymGroupInfo>, IMessage, IEquatable<LordGymGroupInfo>, IDeepCloneable<LordGymGroupInfo>, IBufferMessage
	{
		// Token: 0x0600D34B RID: 54091 RVA: 0x001F21AA File Offset: 0x001F03AA
		[NullableContext(1)]
		public static LordGymGroupInfo Create()
		{
			return new LordGymGroupInfo();
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600D34C RID: 54092 RVA: 0x001F21B1 File Offset: 0x001F03B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LordGymGroupInfo> Parser
		{
			get
			{
				return LordGymGroupInfo._parser;
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600D34D RID: 54093 RVA: 0x001F21B8 File Offset: 0x001F03B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600D34E RID: 54094 RVA: 0x001F21BB File Offset: 0x001F03BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymGroupInfo.Descriptor;
			}
		}

		// Token: 0x0600D34F RID: 54095 RVA: 0x001F21C2 File Offset: 0x001F03C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfo()
		{
		}

		// Token: 0x0600D350 RID: 54096 RVA: 0x001F21CA File Offset: 0x001F03CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfo(LordGymGroupInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.passDiff_ = other.passDiff_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D351 RID: 54097 RVA: 0x001F21FB File Offset: 0x001F03FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfo Clone()
		{
			return new LordGymGroupInfo(this);
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0600D352 RID: 54098 RVA: 0x001F2203 File Offset: 0x001F0403
		// (set) Token: 0x0600D353 RID: 54099 RVA: 0x001F220B File Offset: 0x001F040B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0600D354 RID: 54100 RVA: 0x001F2214 File Offset: 0x001F0414
		// (set) Token: 0x0600D355 RID: 54101 RVA: 0x001F221C File Offset: 0x001F041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassDiff
		{
			get
			{
				return this.passDiff_;
			}
			set
			{
				this.passDiff_ = value;
			}
		}

		// Token: 0x0600D356 RID: 54102 RVA: 0x001F2225 File Offset: 0x001F0425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymGroupInfo);
		}

		// Token: 0x0600D357 RID: 54103 RVA: 0x001F2233 File Offset: 0x001F0433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymGroupInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.PassDiff == other.PassDiff && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D358 RID: 54104 RVA: 0x001F2274 File Offset: 0x001F0474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.PassDiff != 0)
			{
				num ^= this.PassDiff.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D359 RID: 54105 RVA: 0x001F22CC File Offset: 0x001F04CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D35A RID: 54106 RVA: 0x001F22D9 File Offset: 0x001F04D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D35B RID: 54107 RVA: 0x001F22E4 File Offset: 0x001F04E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.PassDiff != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PassDiff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D35C RID: 54108 RVA: 0x001F233C File Offset: 0x001F053C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.PassDiff != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassDiff);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x001F2394 File Offset: 0x001F0594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.PassDiff != 0)
			{
				this.PassDiff = other.PassDiff;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D35E RID: 54110 RVA: 0x001F23E4 File Offset: 0x001F05E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D35F RID: 54111 RVA: 0x001F23F0 File Offset: 0x001F05F0
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
						this.PassDiff = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040058CD RID: 22733
		private static readonly MessageParser<LordGymGroupInfo> _parser = new MessageParser<LordGymGroupInfo>(() => new LordGymGroupInfo());

		// Token: 0x040058CE RID: 22734
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058CF RID: 22735
		public const int GroupIdFieldNumber = 1;

		// Token: 0x040058D0 RID: 22736
		private int groupId_;

		// Token: 0x040058D1 RID: 22737
		public const int PassDiffFieldNumber = 2;

		// Token: 0x040058D2 RID: 22738
		private int passDiff_;
	}
}
