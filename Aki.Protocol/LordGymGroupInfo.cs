using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094D RID: 2381
	public sealed class LordGymGroupInfo : IMessage<LordGymGroupInfo>, IMessage, IEquatable<LordGymGroupInfo>, IDeepCloneable<LordGymGroupInfo>, IBufferMessage
	{
		// Token: 0x0600D231 RID: 53809 RVA: 0x001EFFC6 File Offset: 0x001EE1C6
		[NullableContext(1)]
		public static LordGymGroupInfo Create()
		{
			return new LordGymGroupInfo();
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0600D232 RID: 53810 RVA: 0x001EFFCD File Offset: 0x001EE1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LordGymGroupInfo> Parser
		{
			get
			{
				return LordGymGroupInfo._parser;
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0600D233 RID: 53811 RVA: 0x001EFFD4 File Offset: 0x001EE1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0600D234 RID: 53812 RVA: 0x001EFFD7 File Offset: 0x001EE1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymGroupInfo.Descriptor;
			}
		}

		// Token: 0x0600D235 RID: 53813 RVA: 0x001EFFDE File Offset: 0x001EE1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfo()
		{
		}

		// Token: 0x0600D236 RID: 53814 RVA: 0x001EFFE6 File Offset: 0x001EE1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfo(LordGymGroupInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.passDiff_ = other.passDiff_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x001F0017 File Offset: 0x001EE217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfo Clone()
		{
			return new LordGymGroupInfo(this);
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0600D238 RID: 53816 RVA: 0x001F001F File Offset: 0x001EE21F
		// (set) Token: 0x0600D239 RID: 53817 RVA: 0x001F0027 File Offset: 0x001EE227
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

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600D23A RID: 53818 RVA: 0x001F0030 File Offset: 0x001EE230
		// (set) Token: 0x0600D23B RID: 53819 RVA: 0x001F0038 File Offset: 0x001EE238
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

		// Token: 0x0600D23C RID: 53820 RVA: 0x001F0041 File Offset: 0x001EE241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymGroupInfo);
		}

		// Token: 0x0600D23D RID: 53821 RVA: 0x001F004F File Offset: 0x001EE24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymGroupInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.PassDiff == other.PassDiff && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D23E RID: 53822 RVA: 0x001F0090 File Offset: 0x001EE290
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

		// Token: 0x0600D23F RID: 53823 RVA: 0x001F00E8 File Offset: 0x001EE2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x001F00F5 File Offset: 0x001EE2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D241 RID: 53825 RVA: 0x001F0100 File Offset: 0x001EE300
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

		// Token: 0x0600D242 RID: 53826 RVA: 0x001F0158 File Offset: 0x001EE358
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

		// Token: 0x0600D243 RID: 53827 RVA: 0x001F01B0 File Offset: 0x001EE3B0
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

		// Token: 0x0600D244 RID: 53828 RVA: 0x001F0200 File Offset: 0x001EE400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x001F020C File Offset: 0x001EE40C
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

		// Token: 0x040058D6 RID: 22742
		private static readonly MessageParser<LordGymGroupInfo> _parser = new MessageParser<LordGymGroupInfo>(() => new LordGymGroupInfo());

		// Token: 0x040058D7 RID: 22743
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058D8 RID: 22744
		public const int GroupIdFieldNumber = 1;

		// Token: 0x040058D9 RID: 22745
		private int groupId_;

		// Token: 0x040058DA RID: 22746
		public const int PassDiffFieldNumber = 2;

		// Token: 0x040058DB RID: 22747
		private int passDiff_;
	}
}
