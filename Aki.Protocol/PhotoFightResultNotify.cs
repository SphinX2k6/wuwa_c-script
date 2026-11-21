using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1C RID: 3356
	[NetMessage(EMessageId.PhotoFightResultNotify)]
	public sealed class PhotoFightResultNotify : IMessage<PhotoFightResultNotify>, IMessage, IEquatable<PhotoFightResultNotify>, IDeepCloneable<PhotoFightResultNotify>, IBufferMessage
	{
		// Token: 0x06012257 RID: 74327 RVA: 0x002A6FEF File Offset: 0x002A51EF
		[NullableContext(1)]
		public static PhotoFightResultNotify Create()
		{
			return new PhotoFightResultNotify();
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x06012258 RID: 74328 RVA: 0x002A6FF6 File Offset: 0x002A51F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x06012259 RID: 74329 RVA: 0x002A6FF9 File Offset: 0x002A51F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightResultNotify.Descriptor;
			}
		}

		// Token: 0x0601225A RID: 74330 RVA: 0x002A7000 File Offset: 0x002A5200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightResultNotify()
		{
		}

		// Token: 0x0601225B RID: 74331 RVA: 0x002A7014 File Offset: 0x002A5214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightResultNotify(PhotoFightResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.groupId_ = other.groupId_;
			this.levelId_ = other.levelId_;
			this.succ_ = other.succ_;
			this.targets_ = other.targets_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601225C RID: 74332 RVA: 0x002A7085 File Offset: 0x002A5285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightResultNotify Clone()
		{
			return new PhotoFightResultNotify(this);
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0601225D RID: 74333 RVA: 0x002A708D File Offset: 0x002A528D
		// (set) Token: 0x0601225E RID: 74334 RVA: 0x002A7095 File Offset: 0x002A5295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0601225F RID: 74335 RVA: 0x002A709E File Offset: 0x002A529E
		// (set) Token: 0x06012260 RID: 74336 RVA: 0x002A70A6 File Offset: 0x002A52A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x06012261 RID: 74337 RVA: 0x002A70AF File Offset: 0x002A52AF
		// (set) Token: 0x06012262 RID: 74338 RVA: 0x002A70B7 File Offset: 0x002A52B7
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

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x06012263 RID: 74339 RVA: 0x002A70C0 File Offset: 0x002A52C0
		// (set) Token: 0x06012264 RID: 74340 RVA: 0x002A70C8 File Offset: 0x002A52C8
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

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x06012265 RID: 74341 RVA: 0x002A70D1 File Offset: 0x002A52D1
		// (set) Token: 0x06012266 RID: 74342 RVA: 0x002A70D9 File Offset: 0x002A52D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x06012267 RID: 74343 RVA: 0x002A70E2 File Offset: 0x002A52E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightTargetPb> Targets
		{
			get
			{
				return this.targets_;
			}
		}

		// Token: 0x06012268 RID: 74344 RVA: 0x002A70EA File Offset: 0x002A52EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightResultNotify);
		}

		// Token: 0x06012269 RID: 74345 RVA: 0x002A70F8 File Offset: 0x002A52F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.GroupId == other.GroupId && this.LevelId == other.LevelId && this.Succ == other.Succ && this.targets_.Equals(other.targets_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601226A RID: 74346 RVA: 0x002A7188 File Offset: 0x002A5388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			num ^= this.targets_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601226B RID: 74347 RVA: 0x002A723F File Offset: 0x002A543F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601226C RID: 74348 RVA: 0x002A724C File Offset: 0x002A544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601226D RID: 74349 RVA: 0x002A7258 File Offset: 0x002A5458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Succ)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Succ);
			}
			this.targets_.WriteTo(ref output, PhotoFightResultNotify._repeated_targets_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601226E RID: 74350 RVA: 0x002A7318 File Offset: 0x002A5518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.Succ)
			{
				num += 2;
			}
			num += this.targets_.CalculateSize(PhotoFightResultNotify._repeated_targets_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601226F RID: 74351 RVA: 0x002A73C0 File Offset: 0x002A55C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			this.targets_.Add(other.targets_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012270 RID: 74352 RVA: 0x002A745D File Offset: 0x002A565D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012271 RID: 74353 RVA: 0x002A7468 File Offset: 0x002A5668
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
					if (num == 74U)
					{
						this.targets_.AddEntriesFrom(ref input, PhotoFightResultNotify._repeated_targets_codec);
						continue;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040071CC RID: 29132
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071CD RID: 29133
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040071CE RID: 29134
		private ErrorCode errorCode_;

		// Token: 0x040071CF RID: 29135
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040071D0 RID: 29136
		private int activityId_;

		// Token: 0x040071D1 RID: 29137
		public const int GroupIdFieldNumber = 2;

		// Token: 0x040071D2 RID: 29138
		private int groupId_;

		// Token: 0x040071D3 RID: 29139
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040071D4 RID: 29140
		private int levelId_;

		// Token: 0x040071D5 RID: 29141
		public const int SuccFieldNumber = 5;

		// Token: 0x040071D6 RID: 29142
		private bool succ_;

		// Token: 0x040071D7 RID: 29143
		public const int TargetsFieldNumber = 9;

		// Token: 0x040071D8 RID: 29144
		private static readonly FieldCodec<PhotoFightTargetPb> _repeated_targets_codec = FieldCodec.ForMessage<PhotoFightTargetPb>(74U, PhotoFightTargetPb.Parser);

		// Token: 0x040071D9 RID: 29145
		private readonly RepeatedField<PhotoFightTargetPb> targets_ = new RepeatedField<PhotoFightTargetPb>();
	}
}
