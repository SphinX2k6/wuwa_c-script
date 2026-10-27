using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001393 RID: 5011
	[NetMessage(EMessageId.ToughCalcExtraRatioChangePush)]
	public sealed class ToughCalcExtraRatioChangePush : IMessage<ToughCalcExtraRatioChangePush>, IMessage, IEquatable<ToughCalcExtraRatioChangePush>, IDeepCloneable<ToughCalcExtraRatioChangePush>, IBufferMessage
	{
		// Token: 0x0601A978 RID: 108920 RVA: 0x003DB98C File Offset: 0x003D9B8C
		[NullableContext(1)]
		public static ToughCalcExtraRatioChangePush Create()
		{
			return new ToughCalcExtraRatioChangePush();
		}

		// Token: 0x170059A9 RID: 22953
		// (get) Token: 0x0601A979 RID: 108921 RVA: 0x003DB993 File Offset: 0x003D9B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059AA RID: 22954
		// (get) Token: 0x0601A97A RID: 108922 RVA: 0x003DB996 File Offset: 0x003D9B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToughCalcExtraRatioChangePush.Descriptor;
			}
		}

		// Token: 0x0601A97B RID: 108923 RVA: 0x003DB99D File Offset: 0x003D9B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush()
		{
		}

		// Token: 0x0601A97C RID: 108924 RVA: 0x003DB9A5 File Offset: 0x003D9BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush(ToughCalcExtraRatioChangePush other) : this()
		{
			this.id_ = other.id_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A97D RID: 108925 RVA: 0x003DB9D6 File Offset: 0x003D9BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush Clone()
		{
			return new ToughCalcExtraRatioChangePush(this);
		}

		// Token: 0x170059AB RID: 22955
		// (get) Token: 0x0601A97E RID: 108926 RVA: 0x003DB9DE File Offset: 0x003D9BDE
		// (set) Token: 0x0601A97F RID: 108927 RVA: 0x003DB9E6 File Offset: 0x003D9BE6
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

		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x0601A980 RID: 108928 RVA: 0x003DB9EF File Offset: 0x003D9BEF
		// (set) Token: 0x0601A981 RID: 108929 RVA: 0x003DB9F7 File Offset: 0x003D9BF7
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

		// Token: 0x0601A982 RID: 108930 RVA: 0x003DBA00 File Offset: 0x003D9C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToughCalcExtraRatioChangePush);
		}

		// Token: 0x0601A983 RID: 108931 RVA: 0x003DBA0E File Offset: 0x003D9C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ToughCalcExtraRatioChangePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A984 RID: 108932 RVA: 0x003DBA4C File Offset: 0x003D9C4C
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

		// Token: 0x0601A985 RID: 108933 RVA: 0x003DBAA4 File Offset: 0x003D9CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A986 RID: 108934 RVA: 0x003DBAB1 File Offset: 0x003D9CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A987 RID: 108935 RVA: 0x003DBABC File Offset: 0x003D9CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A988 RID: 108936 RVA: 0x003DBB18 File Offset: 0x003D9D18
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

		// Token: 0x0601A989 RID: 108937 RVA: 0x003DBB70 File Offset: 0x003D9D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ToughCalcExtraRatioChangePush other)
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

		// Token: 0x0601A98A RID: 108938 RVA: 0x003DBBC0 File Offset: 0x003D9DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A98B RID: 108939 RVA: 0x003DBBCC File Offset: 0x003D9DCC
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Duration = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009A8E RID: 39566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A8F RID: 39567
		public const int IdFieldNumber = 11;

		// Token: 0x04009A90 RID: 39568
		private long id_;

		// Token: 0x04009A91 RID: 39569
		public const int DurationFieldNumber = 12;

		// Token: 0x04009A92 RID: 39570
		private int duration_;
	}
}
