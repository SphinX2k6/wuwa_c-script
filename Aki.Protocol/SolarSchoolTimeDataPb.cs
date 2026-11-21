using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D0 RID: 4816
	public sealed class SolarSchoolTimeDataPb : IMessage<SolarSchoolTimeDataPb>, IMessage, IEquatable<SolarSchoolTimeDataPb>, IDeepCloneable<SolarSchoolTimeDataPb>, IBufferMessage
	{
		// Token: 0x06019B4D RID: 105293 RVA: 0x003C02D5 File Offset: 0x003BE4D5
		[NullableContext(1)]
		public static SolarSchoolTimeDataPb Create()
		{
			return new SolarSchoolTimeDataPb();
		}

		// Token: 0x1700570E RID: 22286
		// (get) Token: 0x06019B4E RID: 105294 RVA: 0x003C02DC File Offset: 0x003BE4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x06019B4F RID: 105295 RVA: 0x003C02DF File Offset: 0x003BE4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolTimeDataPb.Descriptor;
			}
		}

		// Token: 0x06019B50 RID: 105296 RVA: 0x003C02E6 File Offset: 0x003BE4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTimeDataPb()
		{
		}

		// Token: 0x06019B51 RID: 105297 RVA: 0x003C02EE File Offset: 0x003BE4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTimeDataPb(SolarSchoolTimeDataPb other) : this()
		{
			this.dayIndex_ = other.dayIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B52 RID: 105298 RVA: 0x003C0313 File Offset: 0x003BE513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTimeDataPb Clone()
		{
			return new SolarSchoolTimeDataPb(this);
		}

		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x06019B53 RID: 105299 RVA: 0x003C031B File Offset: 0x003BE51B
		// (set) Token: 0x06019B54 RID: 105300 RVA: 0x003C0323 File Offset: 0x003BE523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DayIndex
		{
			get
			{
				return this.dayIndex_;
			}
			set
			{
				this.dayIndex_ = value;
			}
		}

		// Token: 0x06019B55 RID: 105301 RVA: 0x003C032C File Offset: 0x003BE52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolTimeDataPb);
		}

		// Token: 0x06019B56 RID: 105302 RVA: 0x003C033A File Offset: 0x003BE53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolTimeDataPb other)
		{
			return other != null && (other == this || (this.DayIndex == other.DayIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B57 RID: 105303 RVA: 0x003C0368 File Offset: 0x003BE568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DayIndex != 0)
			{
				num ^= this.DayIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B58 RID: 105304 RVA: 0x003C03A7 File Offset: 0x003BE5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B59 RID: 105305 RVA: 0x003C03B4 File Offset: 0x003BE5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B5A RID: 105306 RVA: 0x003C03BD File Offset: 0x003BE5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DayIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DayIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B5B RID: 105307 RVA: 0x003C03F0 File Offset: 0x003BE5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DayIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DayIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B5C RID: 105308 RVA: 0x003C042E File Offset: 0x003BE62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolTimeDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DayIndex != 0)
			{
				this.DayIndex = other.DayIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B5D RID: 105309 RVA: 0x003C045F File Offset: 0x003BE65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B5E RID: 105310 RVA: 0x003C0468 File Offset: 0x003BE668
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DayIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x040097D4 RID: 38868
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097D5 RID: 38869
		public const int DayIndexFieldNumber = 1;

		// Token: 0x040097D6 RID: 38870
		private int dayIndex_;
	}
}
