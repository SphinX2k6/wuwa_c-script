using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001274 RID: 4724
	[NetMessage(EMessageId.SpringFestivalAtmosphereRewardRequest)]
	public sealed class SpringFestivalAtmosphereRewardRequest : IMessage<SpringFestivalAtmosphereRewardRequest>, IMessage, IEquatable<SpringFestivalAtmosphereRewardRequest>, IDeepCloneable<SpringFestivalAtmosphereRewardRequest>, IBufferMessage
	{
		// Token: 0x060192AC RID: 103084 RVA: 0x003A9896 File Offset: 0x003A7A96
		[NullableContext(1)]
		public static SpringFestivalAtmosphereRewardRequest Create()
		{
			return new SpringFestivalAtmosphereRewardRequest();
		}

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x060192AD RID: 103085 RVA: 0x003A989D File Offset: 0x003A7A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x060192AE RID: 103086 RVA: 0x003A98A0 File Offset: 0x003A7AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAtmosphereRewardRequest.Descriptor;
			}
		}

		// Token: 0x060192AF RID: 103087 RVA: 0x003A98A7 File Offset: 0x003A7AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardRequest()
		{
		}

		// Token: 0x060192B0 RID: 103088 RVA: 0x003A98BA File Offset: 0x003A7ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardRequest(SpringFestivalAtmosphereRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.levelIds_ = other.levelIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192B1 RID: 103089 RVA: 0x003A98F0 File Offset: 0x003A7AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardRequest Clone()
		{
			return new SpringFestivalAtmosphereRewardRequest(this);
		}

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x060192B2 RID: 103090 RVA: 0x003A98F8 File Offset: 0x003A7AF8
		// (set) Token: 0x060192B3 RID: 103091 RVA: 0x003A9900 File Offset: 0x003A7B00
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

		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x060192B4 RID: 103092 RVA: 0x003A9909 File Offset: 0x003A7B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LevelIds
		{
			get
			{
				return this.levelIds_;
			}
		}

		// Token: 0x060192B5 RID: 103093 RVA: 0x003A9911 File Offset: 0x003A7B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAtmosphereRewardRequest);
		}

		// Token: 0x060192B6 RID: 103094 RVA: 0x003A9920 File Offset: 0x003A7B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAtmosphereRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.levelIds_.Equals(other.levelIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192B7 RID: 103095 RVA: 0x003A9970 File Offset: 0x003A7B70
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

		// Token: 0x060192B8 RID: 103096 RVA: 0x003A99BD File Offset: 0x003A7BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192B9 RID: 103097 RVA: 0x003A99CA File Offset: 0x003A7BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192BA RID: 103098 RVA: 0x003A99D4 File Offset: 0x003A7BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.levelIds_.WriteTo(ref output, SpringFestivalAtmosphereRewardRequest._repeated_levelIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192BB RID: 103099 RVA: 0x003A9A24 File Offset: 0x003A7C24
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

		// Token: 0x060192BC RID: 103100 RVA: 0x003A9A78 File Offset: 0x003A7C78
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

		// Token: 0x060192BD RID: 103101 RVA: 0x003A9AC5 File Offset: 0x003A7CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192BE RID: 103102 RVA: 0x003A9AD0 File Offset: 0x003A7CD0
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
				if (num != 48U)
				{
					if (num != 96U && num != 98U)
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

		// Token: 0x04009436 RID: 37942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009437 RID: 37943
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04009438 RID: 37944
		private int activityId_;

		// Token: 0x04009439 RID: 37945
		public const int LevelIdsFieldNumber = 12;

		// Token: 0x0400943A RID: 37946
		private static readonly FieldCodec<int> _repeated_levelIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400943B RID: 37947
		private readonly RepeatedField<int> levelIds_ = new RepeatedField<int>();
	}
}
