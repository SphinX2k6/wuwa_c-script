using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001194 RID: 4500
	public sealed class SceneTimeInfo : IMessage<SceneTimeInfo>, IMessage, IEquatable<SceneTimeInfo>, IDeepCloneable<SceneTimeInfo>, IBufferMessage
	{
		// Token: 0x06017FBA RID: 98234 RVA: 0x0037BAEB File Offset: 0x00379CEB
		[NullableContext(1)]
		public static SceneTimeInfo Create()
		{
			return new SceneTimeInfo();
		}

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x06017FBB RID: 98235 RVA: 0x0037BAF2 File Offset: 0x00379CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x06017FBC RID: 98236 RVA: 0x0037BAF5 File Offset: 0x00379CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneTimeInfo.Descriptor;
			}
		}

		// Token: 0x06017FBD RID: 98237 RVA: 0x0037BAFC File Offset: 0x00379CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo()
		{
		}

		// Token: 0x06017FBE RID: 98238 RVA: 0x0037BB04 File Offset: 0x00379D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo(SceneTimeInfo other) : this()
		{
			this.hour_ = other.hour_;
			this.minute_ = other.minute_;
			this.ownerTimeClockTimeSpan_ = other.ownerTimeClockTimeSpan_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FBF RID: 98239 RVA: 0x0037BB41 File Offset: 0x00379D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo Clone()
		{
			return new SceneTimeInfo(this);
		}

		// Token: 0x1700509A RID: 20634
		// (get) Token: 0x06017FC0 RID: 98240 RVA: 0x0037BB49 File Offset: 0x00379D49
		// (set) Token: 0x06017FC1 RID: 98241 RVA: 0x0037BB51 File Offset: 0x00379D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Hour
		{
			get
			{
				return this.hour_;
			}
			set
			{
				this.hour_ = value;
			}
		}

		// Token: 0x1700509B RID: 20635
		// (get) Token: 0x06017FC2 RID: 98242 RVA: 0x0037BB5A File Offset: 0x00379D5A
		// (set) Token: 0x06017FC3 RID: 98243 RVA: 0x0037BB62 File Offset: 0x00379D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Minute
		{
			get
			{
				return this.minute_;
			}
			set
			{
				this.minute_ = value;
			}
		}

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x06017FC4 RID: 98244 RVA: 0x0037BB6B File Offset: 0x00379D6B
		// (set) Token: 0x06017FC5 RID: 98245 RVA: 0x0037BB73 File Offset: 0x00379D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerTimeClockTimeSpan
		{
			get
			{
				return this.ownerTimeClockTimeSpan_;
			}
			set
			{
				this.ownerTimeClockTimeSpan_ = value;
			}
		}

		// Token: 0x06017FC6 RID: 98246 RVA: 0x0037BB7C File Offset: 0x00379D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneTimeInfo);
		}

		// Token: 0x06017FC7 RID: 98247 RVA: 0x0037BB8C File Offset: 0x00379D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneTimeInfo other)
		{
			return other != null && (other == this || (this.Hour == other.Hour && this.Minute == other.Minute && this.OwnerTimeClockTimeSpan == other.OwnerTimeClockTimeSpan && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FC8 RID: 98248 RVA: 0x0037BBE8 File Offset: 0x00379DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Hour != 0)
			{
				num ^= this.Hour.GetHashCode();
			}
			if (this.Minute != 0)
			{
				num ^= this.Minute.GetHashCode();
			}
			if (this.OwnerTimeClockTimeSpan != 0L)
			{
				num ^= this.OwnerTimeClockTimeSpan.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017FC9 RID: 98249 RVA: 0x0037BC59 File Offset: 0x00379E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FCA RID: 98250 RVA: 0x0037BC66 File Offset: 0x00379E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FCB RID: 98251 RVA: 0x0037BC70 File Offset: 0x00379E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Hour != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Hour);
			}
			if (this.Minute != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Minute);
			}
			if (this.OwnerTimeClockTimeSpan != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.OwnerTimeClockTimeSpan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FCC RID: 98252 RVA: 0x0037BCE4 File Offset: 0x00379EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Hour != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Hour);
			}
			if (this.Minute != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Minute);
			}
			if (this.OwnerTimeClockTimeSpan != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OwnerTimeClockTimeSpan);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017FCD RID: 98253 RVA: 0x0037BD54 File Offset: 0x00379F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneTimeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Hour != 0)
			{
				this.Hour = other.Hour;
			}
			if (other.Minute != 0)
			{
				this.Minute = other.Minute;
			}
			if (other.OwnerTimeClockTimeSpan != 0L)
			{
				this.OwnerTimeClockTimeSpan = other.OwnerTimeClockTimeSpan;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017FCE RID: 98254 RVA: 0x0037BDB8 File Offset: 0x00379FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FCF RID: 98255 RVA: 0x0037BDC4 File Offset: 0x00379FC4
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OwnerTimeClockTimeSpan = input.ReadInt64();
						}
					}
					else
					{
						this.Minute = input.ReadInt32();
					}
				}
				else
				{
					this.Hour = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E10 RID: 36368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E11 RID: 36369
		public const int HourFieldNumber = 1;

		// Token: 0x04008E12 RID: 36370
		private int hour_;

		// Token: 0x04008E13 RID: 36371
		public const int MinuteFieldNumber = 2;

		// Token: 0x04008E14 RID: 36372
		private int minute_;

		// Token: 0x04008E15 RID: 36373
		public const int OwnerTimeClockTimeSpanFieldNumber = 3;

		// Token: 0x04008E16 RID: 36374
		private long ownerTimeClockTimeSpan_;
	}
}
