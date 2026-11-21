using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CC RID: 4812
	[NetMessage(EMessageId.SolarSchoolTaskProgressRewardRequest)]
	public sealed class SolarSchoolTaskProgressRewardRequest : IMessage<SolarSchoolTaskProgressRewardRequest>, IMessage, IEquatable<SolarSchoolTaskProgressRewardRequest>, IDeepCloneable<SolarSchoolTaskProgressRewardRequest>, IBufferMessage
	{
		// Token: 0x06019B00 RID: 105216 RVA: 0x003BF954 File Offset: 0x003BDB54
		[NullableContext(1)]
		public static SolarSchoolTaskProgressRewardRequest Create()
		{
			return new SolarSchoolTaskProgressRewardRequest();
		}

		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x06019B01 RID: 105217 RVA: 0x003BF95B File Offset: 0x003BDB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x06019B02 RID: 105218 RVA: 0x003BF95E File Offset: 0x003BDB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolTaskProgressRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019B03 RID: 105219 RVA: 0x003BF965 File Offset: 0x003BDB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskProgressRewardRequest()
		{
		}

		// Token: 0x06019B04 RID: 105220 RVA: 0x003BF96D File Offset: 0x003BDB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskProgressRewardRequest(SolarSchoolTaskProgressRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B05 RID: 105221 RVA: 0x003BF992 File Offset: 0x003BDB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskProgressRewardRequest Clone()
		{
			return new SolarSchoolTaskProgressRewardRequest(this);
		}

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x06019B06 RID: 105222 RVA: 0x003BF99A File Offset: 0x003BDB9A
		// (set) Token: 0x06019B07 RID: 105223 RVA: 0x003BF9A2 File Offset: 0x003BDBA2
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

		// Token: 0x06019B08 RID: 105224 RVA: 0x003BF9AB File Offset: 0x003BDBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolTaskProgressRewardRequest);
		}

		// Token: 0x06019B09 RID: 105225 RVA: 0x003BF9B9 File Offset: 0x003BDBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolTaskProgressRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B0A RID: 105226 RVA: 0x003BF9E8 File Offset: 0x003BDBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B0B RID: 105227 RVA: 0x003BFA27 File Offset: 0x003BDC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B0C RID: 105228 RVA: 0x003BFA34 File Offset: 0x003BDC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B0D RID: 105229 RVA: 0x003BFA3D File Offset: 0x003BDC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B0E RID: 105230 RVA: 0x003BFA70 File Offset: 0x003BDC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B0F RID: 105231 RVA: 0x003BFAAE File Offset: 0x003BDCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolTaskProgressRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B10 RID: 105232 RVA: 0x003BFADF File Offset: 0x003BDCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B11 RID: 105233 RVA: 0x003BFAE8 File Offset: 0x003BDCE8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040097C1 RID: 38849
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097C2 RID: 38850
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040097C3 RID: 38851
		private int activityId_;
	}
}
