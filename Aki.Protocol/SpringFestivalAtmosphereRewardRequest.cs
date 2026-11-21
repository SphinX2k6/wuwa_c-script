using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E3 RID: 4835
	[NetMessage(EMessageId.SpringFestivalAtmosphereRewardRequest)]
	public sealed class SpringFestivalAtmosphereRewardRequest : IMessage<SpringFestivalAtmosphereRewardRequest>, IMessage, IEquatable<SpringFestivalAtmosphereRewardRequest>, IDeepCloneable<SpringFestivalAtmosphereRewardRequest>, IBufferMessage
	{
		// Token: 0x06019CE2 RID: 105698 RVA: 0x003C3FE7 File Offset: 0x003C21E7
		[NullableContext(1)]
		public static SpringFestivalAtmosphereRewardRequest Create()
		{
			return new SpringFestivalAtmosphereRewardRequest();
		}

		// Token: 0x1700576C RID: 22380
		// (get) Token: 0x06019CE3 RID: 105699 RVA: 0x003C3FEE File Offset: 0x003C21EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700576D RID: 22381
		// (get) Token: 0x06019CE4 RID: 105700 RVA: 0x003C3FF1 File Offset: 0x003C21F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAtmosphereRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019CE5 RID: 105701 RVA: 0x003C3FF8 File Offset: 0x003C21F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardRequest()
		{
		}

		// Token: 0x06019CE6 RID: 105702 RVA: 0x003C400B File Offset: 0x003C220B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardRequest(SpringFestivalAtmosphereRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.levelIds_ = other.levelIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CE7 RID: 105703 RVA: 0x003C4041 File Offset: 0x003C2241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardRequest Clone()
		{
			return new SpringFestivalAtmosphereRewardRequest(this);
		}

		// Token: 0x1700576E RID: 22382
		// (get) Token: 0x06019CE8 RID: 105704 RVA: 0x003C4049 File Offset: 0x003C2249
		// (set) Token: 0x06019CE9 RID: 105705 RVA: 0x003C4051 File Offset: 0x003C2251
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

		// Token: 0x1700576F RID: 22383
		// (get) Token: 0x06019CEA RID: 105706 RVA: 0x003C405A File Offset: 0x003C225A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LevelIds
		{
			get
			{
				return this.levelIds_;
			}
		}

		// Token: 0x06019CEB RID: 105707 RVA: 0x003C4062 File Offset: 0x003C2262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAtmosphereRewardRequest);
		}

		// Token: 0x06019CEC RID: 105708 RVA: 0x003C4070 File Offset: 0x003C2270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAtmosphereRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.levelIds_.Equals(other.levelIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CED RID: 105709 RVA: 0x003C40C0 File Offset: 0x003C22C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.levelIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019CEE RID: 105710 RVA: 0x003C410D File Offset: 0x003C230D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CEF RID: 105711 RVA: 0x003C411A File Offset: 0x003C231A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CF0 RID: 105712 RVA: 0x003C4124 File Offset: 0x003C2324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.levelIds_.WriteTo(ref output, SpringFestivalAtmosphereRewardRequest._repeated_levelIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019CF1 RID: 105713 RVA: 0x003C4174 File Offset: 0x003C2374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.levelIds_.CalculateSize(SpringFestivalAtmosphereRewardRequest._repeated_levelIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019CF2 RID: 105714 RVA: 0x003C41C8 File Offset: 0x003C23C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalAtmosphereRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.levelIds_.Add(other.levelIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019CF3 RID: 105715 RVA: 0x003C4215 File Offset: 0x003C2415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CF4 RID: 105716 RVA: 0x003C4220 File Offset: 0x003C2420
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
				if (num != 56U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.levelIds_.AddEntriesFrom(ref input, SpringFestivalAtmosphereRewardRequest._repeated_levelIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009860 RID: 39008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009861 RID: 39009
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04009862 RID: 39010
		private int activityId_;

		// Token: 0x04009863 RID: 39011
		public const int LevelIdsFieldNumber = 8;

		// Token: 0x04009864 RID: 39012
		private static readonly FieldCodec<int> _repeated_levelIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009865 RID: 39013
		private readonly RepeatedField<int> levelIds_ = new RepeatedField<int>();
	}
}
