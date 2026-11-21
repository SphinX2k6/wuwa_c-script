using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1B RID: 3355
	public sealed class PhotoFightLevelPb : IMessage<PhotoFightLevelPb>, IMessage, IEquatable<PhotoFightLevelPb>, IDeepCloneable<PhotoFightLevelPb>, IBufferMessage
	{
		// Token: 0x0601223C RID: 74300 RVA: 0x002A6B35 File Offset: 0x002A4D35
		[NullableContext(1)]
		public static PhotoFightLevelPb Create()
		{
			return new PhotoFightLevelPb();
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0601223D RID: 74301 RVA: 0x002A6B3C File Offset: 0x002A4D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoFightLevelPb> Parser
		{
			get
			{
				return PhotoFightLevelPb._parser;
			}
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0601223E RID: 74302 RVA: 0x002A6B43 File Offset: 0x002A4D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0601223F RID: 74303 RVA: 0x002A6B46 File Offset: 0x002A4D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightLevelPb.Descriptor;
			}
		}

		// Token: 0x06012240 RID: 74304 RVA: 0x002A6B4D File Offset: 0x002A4D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelPb()
		{
		}

		// Token: 0x06012241 RID: 74305 RVA: 0x002A6B60 File Offset: 0x002A4D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelPb(PhotoFightLevelPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.instId_ = other.instId_;
			this.roles_ = other.roles_.Clone();
			this.clearTimes_ = other.clearTimes_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012242 RID: 74306 RVA: 0x002A6BC5 File Offset: 0x002A4DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelPb Clone()
		{
			return new PhotoFightLevelPb(this);
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x06012243 RID: 74307 RVA: 0x002A6BCD File Offset: 0x002A4DCD
		// (set) Token: 0x06012244 RID: 74308 RVA: 0x002A6BD5 File Offset: 0x002A4DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x06012245 RID: 74309 RVA: 0x002A6BDE File Offset: 0x002A4DDE
		// (set) Token: 0x06012246 RID: 74310 RVA: 0x002A6BE6 File Offset: 0x002A4DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x06012247 RID: 74311 RVA: 0x002A6BEF File Offset: 0x002A4DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x06012248 RID: 74312 RVA: 0x002A6BF7 File Offset: 0x002A4DF7
		// (set) Token: 0x06012249 RID: 74313 RVA: 0x002A6BFF File Offset: 0x002A4DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClearTimes
		{
			get
			{
				return this.clearTimes_;
			}
			set
			{
				this.clearTimes_ = value;
			}
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0601224A RID: 74314 RVA: 0x002A6C08 File Offset: 0x002A4E08
		// (set) Token: 0x0601224B RID: 74315 RVA: 0x002A6C10 File Offset: 0x002A4E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x0601224C RID: 74316 RVA: 0x002A6C19 File Offset: 0x002A4E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightLevelPb);
		}

		// Token: 0x0601224D RID: 74317 RVA: 0x002A6C28 File Offset: 0x002A4E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightLevelPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.InstId == other.InstId && this.roles_.Equals(other.roles_) && this.ClearTimes == other.ClearTimes && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601224E RID: 74318 RVA: 0x002A6CA8 File Offset: 0x002A4EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			if (this.ClearTimes != 0)
			{
				num ^= this.ClearTimes.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601224F RID: 74319 RVA: 0x002A6D40 File Offset: 0x002A4F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012250 RID: 74320 RVA: 0x002A6D4D File Offset: 0x002A4F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012251 RID: 74321 RVA: 0x002A6D58 File Offset: 0x002A4F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			this.roles_.WriteTo(ref output, PhotoFightLevelPb._repeated_roles_codec);
			if (this.ClearTimes != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ClearTimes);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012252 RID: 74322 RVA: 0x002A6DFC File Offset: 0x002A4FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.roles_.CalculateSize(PhotoFightLevelPb._repeated_roles_codec);
			if (this.ClearTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClearTimes);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012253 RID: 74323 RVA: 0x002A6E8C File Offset: 0x002A508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.roles_.Add(other.roles_);
			if (other.ClearTimes != 0)
			{
				this.ClearTimes = other.ClearTimes;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012254 RID: 74324 RVA: 0x002A6F15 File Offset: 0x002A5115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012255 RID: 74325 RVA: 0x002A6F20 File Offset: 0x002A5120
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_60;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_60;
					}
					if (num == 32U)
					{
						this.ClearTimes = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsOpen = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_60:
				this.roles_.AddEntriesFrom(ref input, PhotoFightLevelPb._repeated_roles_codec);
			}
		}

		// Token: 0x040071BF RID: 29119
		private static readonly MessageParser<PhotoFightLevelPb> _parser = new MessageParser<PhotoFightLevelPb>(() => new PhotoFightLevelPb());

		// Token: 0x040071C0 RID: 29120
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071C1 RID: 29121
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040071C2 RID: 29122
		private int levelId_;

		// Token: 0x040071C3 RID: 29123
		public const int InstIdFieldNumber = 2;

		// Token: 0x040071C4 RID: 29124
		private int instId_;

		// Token: 0x040071C5 RID: 29125
		public const int RolesFieldNumber = 3;

		// Token: 0x040071C6 RID: 29126
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040071C7 RID: 29127
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x040071C8 RID: 29128
		public const int ClearTimesFieldNumber = 4;

		// Token: 0x040071C9 RID: 29129
		private int clearTimes_;

		// Token: 0x040071CA RID: 29130
		public const int IsOpenFieldNumber = 5;

		// Token: 0x040071CB RID: 29131
		private bool isOpen_;
	}
}
