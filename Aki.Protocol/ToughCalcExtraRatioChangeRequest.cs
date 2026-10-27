using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001394 RID: 5012
	[NetMessage(EMessageId.ToughCalcExtraRatioChangeRequest)]
	public sealed class ToughCalcExtraRatioChangeRequest : IMessage<ToughCalcExtraRatioChangeRequest>, IMessage, IEquatable<ToughCalcExtraRatioChangeRequest>, IDeepCloneable<ToughCalcExtraRatioChangeRequest>, IBufferMessage
	{
		// Token: 0x0601A98C RID: 108940 RVA: 0x003DBC24 File Offset: 0x003D9E24
		[NullableContext(1)]
		public static ToughCalcExtraRatioChangeRequest Create()
		{
			return new ToughCalcExtraRatioChangeRequest();
		}

		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x0601A98D RID: 108941 RVA: 0x003DBC2B File Offset: 0x003D9E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x0601A98E RID: 108942 RVA: 0x003DBC2E File Offset: 0x003D9E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToughCalcExtraRatioChangeRequest.Descriptor;
			}
		}

		// Token: 0x0601A98F RID: 108943 RVA: 0x003DBC35 File Offset: 0x003D9E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest()
		{
		}

		// Token: 0x0601A990 RID: 108944 RVA: 0x003DBC3D File Offset: 0x003D9E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest(ToughCalcExtraRatioChangeRequest other) : this()
		{
			this.id_ = other.id_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A991 RID: 108945 RVA: 0x003DBC6E File Offset: 0x003D9E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest Clone()
		{
			return new ToughCalcExtraRatioChangeRequest(this);
		}

		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x0601A992 RID: 108946 RVA: 0x003DBC76 File Offset: 0x003D9E76
		// (set) Token: 0x0601A993 RID: 108947 RVA: 0x003DBC7E File Offset: 0x003D9E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x0601A994 RID: 108948 RVA: 0x003DBC87 File Offset: 0x003D9E87
		// (set) Token: 0x0601A995 RID: 108949 RVA: 0x003DBC8F File Offset: 0x003D9E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x0601A996 RID: 108950 RVA: 0x003DBC98 File Offset: 0x003D9E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToughCalcExtraRatioChangeRequest);
		}

		// Token: 0x0601A997 RID: 108951 RVA: 0x003DBCA6 File Offset: 0x003D9EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ToughCalcExtraRatioChangeRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A998 RID: 108952 RVA: 0x003DBCE4 File Offset: 0x003D9EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A999 RID: 108953 RVA: 0x003DBD3C File Offset: 0x003D9F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A99A RID: 108954 RVA: 0x003DBD49 File Offset: 0x003D9F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A99B RID: 108955 RVA: 0x003DBD54 File Offset: 0x003D9F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Duration);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A99C RID: 108956 RVA: 0x003DBDB0 File Offset: 0x003D9FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A99D RID: 108957 RVA: 0x003DBE08 File Offset: 0x003DA008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ToughCalcExtraRatioChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A99E RID: 108958 RVA: 0x003DBE58 File Offset: 0x003DA058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A99F RID: 108959 RVA: 0x003DBE64 File Offset: 0x003DA064
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
				if (num != 32U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A93 RID: 39571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A94 RID: 39572
		public const int IdFieldNumber = 13;

		// Token: 0x04009A95 RID: 39573
		private long id_;

		// Token: 0x04009A96 RID: 39574
		public const int DurationFieldNumber = 4;

		// Token: 0x04009A97 RID: 39575
		private int duration_;
	}
}
