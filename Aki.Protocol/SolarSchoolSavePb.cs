using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BF RID: 4799
	public sealed class SolarSchoolSavePb : IMessage<SolarSchoolSavePb>, IMessage, IEquatable<SolarSchoolSavePb>, IDeepCloneable<SolarSchoolSavePb>, IBufferMessage
	{
		// Token: 0x060199DA RID: 104922 RVA: 0x003BCC2D File Offset: 0x003BAE2D
		[NullableContext(1)]
		public static SolarSchoolSavePb Create()
		{
			return new SolarSchoolSavePb();
		}

		// Token: 0x170056B9 RID: 22201
		// (get) Token: 0x060199DB RID: 104923 RVA: 0x003BCC34 File Offset: 0x003BAE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056BA RID: 22202
		// (get) Token: 0x060199DC RID: 104924 RVA: 0x003BCC37 File Offset: 0x003BAE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSavePb.Descriptor;
			}
		}

		// Token: 0x060199DD RID: 104925 RVA: 0x003BCC3E File Offset: 0x003BAE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePb()
		{
		}

		// Token: 0x060199DE RID: 104926 RVA: 0x003BCC48 File Offset: 0x003BAE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePb(SolarSchoolSavePb other) : this()
		{
			this.preview_ = ((other.preview_ != null) ? other.preview_.Clone() : null);
			this.activityId_ = other.activityId_;
			this.game_ = ((other.game_ != null) ? other.game_.Clone() : null);
			this.version_ = other.version_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199DF RID: 104927 RVA: 0x003BCCC8 File Offset: 0x003BAEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePb Clone()
		{
			return new SolarSchoolSavePb(this);
		}

		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x060199E0 RID: 104928 RVA: 0x003BCCD0 File Offset: 0x003BAED0
		// (set) Token: 0x060199E1 RID: 104929 RVA: 0x003BCCD8 File Offset: 0x003BAED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePreviewPb Preview
		{
			get
			{
				return this.preview_;
			}
			set
			{
				this.preview_ = value;
			}
		}

		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x060199E2 RID: 104930 RVA: 0x003BCCE1 File Offset: 0x003BAEE1
		// (set) Token: 0x060199E3 RID: 104931 RVA: 0x003BCCE9 File Offset: 0x003BAEE9
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

		// Token: 0x170056BD RID: 22205
		// (get) Token: 0x060199E4 RID: 104932 RVA: 0x003BCCF2 File Offset: 0x003BAEF2
		// (set) Token: 0x060199E5 RID: 104933 RVA: 0x003BCCFA File Offset: 0x003BAEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveGamePb Game
		{
			get
			{
				return this.game_;
			}
			set
			{
				this.game_ = value;
			}
		}

		// Token: 0x170056BE RID: 22206
		// (get) Token: 0x060199E6 RID: 104934 RVA: 0x003BCD03 File Offset: 0x003BAF03
		// (set) Token: 0x060199E7 RID: 104935 RVA: 0x003BCD0B File Offset: 0x003BAF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x060199E8 RID: 104936 RVA: 0x003BCD14 File Offset: 0x003BAF14
		// (set) Token: 0x060199E9 RID: 104937 RVA: 0x003BCD1C File Offset: 0x003BAF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = value;
			}
		}

		// Token: 0x060199EA RID: 104938 RVA: 0x003BCD25 File Offset: 0x003BAF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSavePb);
		}

		// Token: 0x060199EB RID: 104939 RVA: 0x003BCD34 File Offset: 0x003BAF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSavePb other)
		{
			return other != null && (other == this || (object.Equals(this.Preview, other.Preview) && this.ActivityId == other.ActivityId && object.Equals(this.Game, other.Game) && this.Version == other.Version && this.TraceId == other.TraceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199EC RID: 104940 RVA: 0x003BCDB8 File Offset: 0x003BAFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.preview_ != null)
			{
				num ^= this.Preview.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.game_ != null)
			{
				num ^= this.Game.GetHashCode();
			}
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this.TraceId != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060199ED RID: 104941 RVA: 0x003BCE55 File Offset: 0x003BB055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199EE RID: 104942 RVA: 0x003BCE62 File Offset: 0x003BB062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199EF RID: 104943 RVA: 0x003BCE6C File Offset: 0x003BB06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preview_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Preview);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.game_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Game);
			}
			if (this.Version != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Version);
			}
			if (this.TraceId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199F0 RID: 104944 RVA: 0x003BCF1C File Offset: 0x003BB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.preview_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Preview);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.game_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Game);
			}
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this.TraceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060199F1 RID: 104945 RVA: 0x003BCFBC File Offset: 0x003BB1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSavePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.preview_ != null)
			{
				if (this.preview_ == null)
				{
					this.Preview = new SolarSchoolSavePreviewPb();
				}
				this.Preview.MergeFrom(other.Preview);
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.game_ != null)
			{
				if (this.game_ == null)
				{
					this.Game = new SolarSchoolSaveGamePb();
				}
				this.Game.MergeFrom(other.Game);
			}
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			if (other.TraceId != 0)
			{
				this.TraceId = other.TraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060199F2 RID: 104946 RVA: 0x003BD078 File Offset: 0x003BB278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199F3 RID: 104947 RVA: 0x003BD084 File Offset: 0x003BB284
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.preview_ == null)
						{
							this.Preview = new SolarSchoolSavePreviewPb();
						}
						input.ReadMessage(this.Preview);
						continue;
					}
					if (num == 16U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.game_ == null)
						{
							this.Game = new SolarSchoolSaveGamePb();
						}
						input.ReadMessage(this.Game);
						continue;
					}
					if (num == 32U)
					{
						this.Version = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TraceId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009759 RID: 38745
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400975A RID: 38746
		public const int PreviewFieldNumber = 1;

		// Token: 0x0400975B RID: 38747
		private SolarSchoolSavePreviewPb preview_;

		// Token: 0x0400975C RID: 38748
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x0400975D RID: 38749
		private int activityId_;

		// Token: 0x0400975E RID: 38750
		public const int GameFieldNumber = 3;

		// Token: 0x0400975F RID: 38751
		private SolarSchoolSaveGamePb game_;

		// Token: 0x04009760 RID: 38752
		public const int VersionFieldNumber = 4;

		// Token: 0x04009761 RID: 38753
		private int version_;

		// Token: 0x04009762 RID: 38754
		public const int TraceIdFieldNumber = 5;

		// Token: 0x04009763 RID: 38755
		private int traceId_;
	}
}
