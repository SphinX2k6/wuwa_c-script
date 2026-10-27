using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001273 RID: 4723
	[NetMessage(EMessageId.SpringFestivalAreaUnlockNotify)]
	public sealed class SpringFestivalAreaUnlockNotify : IMessage<SpringFestivalAreaUnlockNotify>, IMessage, IEquatable<SpringFestivalAreaUnlockNotify>, IDeepCloneable<SpringFestivalAreaUnlockNotify>, IBufferMessage
	{
		// Token: 0x06019296 RID: 103062 RVA: 0x003A954A File Offset: 0x003A774A
		[NullableContext(1)]
		public static SpringFestivalAreaUnlockNotify Create()
		{
			return new SpringFestivalAreaUnlockNotify();
		}

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x06019297 RID: 103063 RVA: 0x003A9551 File Offset: 0x003A7751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x06019298 RID: 103064 RVA: 0x003A9554 File Offset: 0x003A7754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAreaUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06019299 RID: 103065 RVA: 0x003A955B File Offset: 0x003A775B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAreaUnlockNotify()
		{
		}

		// Token: 0x0601929A RID: 103066 RVA: 0x003A9570 File Offset: 0x003A7770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAreaUnlockNotify(SpringFestivalAreaUnlockNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.areaInfos_ = other.areaInfos_.Clone();
			this.isFullLoad_ = other.isFullLoad_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601929B RID: 103067 RVA: 0x003A95BD File Offset: 0x003A77BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAreaUnlockNotify Clone()
		{
			return new SpringFestivalAreaUnlockNotify(this);
		}

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x0601929C RID: 103068 RVA: 0x003A95C5 File Offset: 0x003A77C5
		// (set) Token: 0x0601929D RID: 103069 RVA: 0x003A95CD File Offset: 0x003A77CD
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

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x0601929E RID: 103070 RVA: 0x003A95D6 File Offset: 0x003A77D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaInfo> AreaInfos
		{
			get
			{
				return this.areaInfos_;
			}
		}

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x0601929F RID: 103071 RVA: 0x003A95DE File Offset: 0x003A77DE
		// (set) Token: 0x060192A0 RID: 103072 RVA: 0x003A95E6 File Offset: 0x003A77E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFullLoad
		{
			get
			{
				return this.isFullLoad_;
			}
			set
			{
				this.isFullLoad_ = value;
			}
		}

		// Token: 0x060192A1 RID: 103073 RVA: 0x003A95EF File Offset: 0x003A77EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAreaUnlockNotify);
		}

		// Token: 0x060192A2 RID: 103074 RVA: 0x003A9600 File Offset: 0x003A7800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAreaUnlockNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.areaInfos_.Equals(other.areaInfos_) && this.IsFullLoad == other.IsFullLoad && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192A3 RID: 103075 RVA: 0x003A9660 File Offset: 0x003A7860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.areaInfos_.GetHashCode();
			if (this.IsFullLoad)
			{
				num ^= this.IsFullLoad.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192A4 RID: 103076 RVA: 0x003A96C6 File Offset: 0x003A78C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192A5 RID: 103077 RVA: 0x003A96D3 File Offset: 0x003A78D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192A6 RID: 103078 RVA: 0x003A96DC File Offset: 0x003A78DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.IsFullLoad)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsFullLoad);
			}
			this.areaInfos_.WriteTo(ref output, SpringFestivalAreaUnlockNotify._repeated_areaInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192A7 RID: 103079 RVA: 0x003A9748 File Offset: 0x003A7948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.areaInfos_.CalculateSize(SpringFestivalAreaUnlockNotify._repeated_areaInfos_codec);
			if (this.IsFullLoad)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192A8 RID: 103080 RVA: 0x003A97A8 File Offset: 0x003A79A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalAreaUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.areaInfos_.Add(other.areaInfos_);
			if (other.IsFullLoad)
			{
				this.IsFullLoad = other.IsFullLoad;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192A9 RID: 103081 RVA: 0x003A9809 File Offset: 0x003A7A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192AA RID: 103082 RVA: 0x003A9814 File Offset: 0x003A7A14
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
					if (num != 88U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.areaInfos_.AddEntriesFrom(ref input, SpringFestivalAreaUnlockNotify._repeated_areaInfos_codec);
						}
					}
					else
					{
						this.IsFullLoad = input.ReadBool();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400942E RID: 37934
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400942F RID: 37935
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04009430 RID: 37936
		private int activityId_;

		// Token: 0x04009431 RID: 37937
		public const int AreaInfosFieldNumber = 14;

		// Token: 0x04009432 RID: 37938
		private static readonly FieldCodec<AreaInfo> _repeated_areaInfos_codec = FieldCodec.ForMessage<AreaInfo>(114U, AreaInfo.Parser);

		// Token: 0x04009433 RID: 37939
		private readonly RepeatedField<AreaInfo> areaInfos_ = new RepeatedField<AreaInfo>();

		// Token: 0x04009434 RID: 37940
		public const int IsFullLoadFieldNumber = 11;

		// Token: 0x04009435 RID: 37941
		private bool isFullLoad_;
	}
}
