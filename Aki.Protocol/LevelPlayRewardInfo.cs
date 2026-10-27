using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000905 RID: 2309
	public sealed class LevelPlayRewardInfo : IMessage<LevelPlayRewardInfo>, IMessage, IEquatable<LevelPlayRewardInfo>, IDeepCloneable<LevelPlayRewardInfo>, IBufferMessage
	{
		// Token: 0x0600CBE8 RID: 52200 RVA: 0x001E10BD File Offset: 0x001DF2BD
		[NullableContext(1)]
		public static LevelPlayRewardInfo Create()
		{
			return new LevelPlayRewardInfo();
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600CBE9 RID: 52201 RVA: 0x001E10C4 File Offset: 0x001DF2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayRewardInfo> Parser
		{
			get
			{
				return LevelPlayRewardInfo._parser;
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600CBEA RID: 52202 RVA: 0x001E10CB File Offset: 0x001DF2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600CBEB RID: 52203 RVA: 0x001E10CE File Offset: 0x001DF2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x001E10D5 File Offset: 0x001DF2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardInfo()
		{
		}

		// Token: 0x0600CBED RID: 52205 RVA: 0x001E10DD File Offset: 0x001DF2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardInfo(LevelPlayRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.getReward_ = other.getReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBEE RID: 52206 RVA: 0x001E110E File Offset: 0x001DF30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardInfo Clone()
		{
			return new LevelPlayRewardInfo(this);
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600CBEF RID: 52207 RVA: 0x001E1116 File Offset: 0x001DF316
		// (set) Token: 0x0600CBF0 RID: 52208 RVA: 0x001E111E File Offset: 0x001DF31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600CBF1 RID: 52209 RVA: 0x001E1127 File Offset: 0x001DF327
		// (set) Token: 0x0600CBF2 RID: 52210 RVA: 0x001E112F File Offset: 0x001DF32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GetReward
		{
			get
			{
				return this.getReward_;
			}
			set
			{
				this.getReward_ = value;
			}
		}

		// Token: 0x0600CBF3 RID: 52211 RVA: 0x001E1138 File Offset: 0x001DF338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardInfo);
		}

		// Token: 0x0600CBF4 RID: 52212 RVA: 0x001E1146 File Offset: 0x001DF346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GetReward == other.GetReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x001E1184 File Offset: 0x001DF384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GetReward)
			{
				num ^= this.GetReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x001E11DC File Offset: 0x001DF3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x001E11E9 File Offset: 0x001DF3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x001E11F4 File Offset: 0x001DF3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GetReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.GetReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x001E124C File Offset: 0x001DF44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GetReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x001E1298 File Offset: 0x001DF498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GetReward)
			{
				this.GetReward = other.GetReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x001E12E8 File Offset: 0x001DF4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBFC RID: 52220 RVA: 0x001E12F4 File Offset: 0x001DF4F4
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
						this.GetReward = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005686 RID: 22150
		private static readonly MessageParser<LevelPlayRewardInfo> _parser = new MessageParser<LevelPlayRewardInfo>(() => new LevelPlayRewardInfo());

		// Token: 0x04005687 RID: 22151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005688 RID: 22152
		public const int IdFieldNumber = 1;

		// Token: 0x04005689 RID: 22153
		private int id_;

		// Token: 0x0400568A RID: 22154
		public const int GetRewardFieldNumber = 2;

		// Token: 0x0400568B RID: 22155
		private bool getReward_;
	}
}
