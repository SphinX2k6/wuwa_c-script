using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113B RID: 4411
	[NetMessage(EMessageId.RTimeStopRequest)]
	public sealed class RTimeStopRequest : IMessage<RTimeStopRequest>, IMessage, IEquatable<RTimeStopRequest>, IDeepCloneable<RTimeStopRequest>, IBufferMessage
	{
		// Token: 0x06017860 RID: 96352 RVA: 0x0036A813 File Offset: 0x00368A13
		[NullableContext(1)]
		public static RTimeStopRequest Create()
		{
			return new RTimeStopRequest();
		}

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x06017861 RID: 96353 RVA: 0x0036A81A File Offset: 0x00368A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x06017862 RID: 96354 RVA: 0x0036A81D File Offset: 0x00368A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopRequest.Descriptor;
			}
		}

		// Token: 0x06017863 RID: 96355 RVA: 0x0036A824 File Offset: 0x00368A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest()
		{
		}

		// Token: 0x06017864 RID: 96356 RVA: 0x0036A82C File Offset: 0x00368A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest(RTimeStopRequest other) : this()
		{
			this.isStopCharacter_ = other.isStopCharacter_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017865 RID: 96357 RVA: 0x0036A85D File Offset: 0x00368A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest Clone()
		{
			return new RTimeStopRequest(this);
		}

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x06017866 RID: 96358 RVA: 0x0036A865 File Offset: 0x00368A65
		// (set) Token: 0x06017867 RID: 96359 RVA: 0x0036A86D File Offset: 0x00368A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStopCharacter
		{
			get
			{
				return this.isStopCharacter_;
			}
			set
			{
				this.isStopCharacter_ = value;
			}
		}

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x06017868 RID: 96360 RVA: 0x0036A876 File Offset: 0x00368A76
		// (set) Token: 0x06017869 RID: 96361 RVA: 0x0036A87E File Offset: 0x00368A7E
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

		// Token: 0x0601786A RID: 96362 RVA: 0x0036A887 File Offset: 0x00368A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopRequest);
		}

		// Token: 0x0601786B RID: 96363 RVA: 0x0036A895 File Offset: 0x00368A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopRequest other)
		{
			return other != null && (other == this || (this.IsStopCharacter == other.IsStopCharacter && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601786C RID: 96364 RVA: 0x0036A8D4 File Offset: 0x00368AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsStopCharacter)
			{
				num ^= this.IsStopCharacter.GetHashCode();
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

		// Token: 0x0601786D RID: 96365 RVA: 0x0036A92C File Offset: 0x00368B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601786E RID: 96366 RVA: 0x0036A939 File Offset: 0x00368B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601786F RID: 96367 RVA: 0x0036A944 File Offset: 0x00368B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Duration);
			}
			if (this.IsStopCharacter)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsStopCharacter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017870 RID: 96368 RVA: 0x0036A9A0 File Offset: 0x00368BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsStopCharacter)
			{
				num += 2;
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

		// Token: 0x06017871 RID: 96369 RVA: 0x0036A9EC File Offset: 0x00368BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsStopCharacter)
			{
				this.IsStopCharacter = other.IsStopCharacter;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017872 RID: 96370 RVA: 0x0036AA3C File Offset: 0x00368C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017873 RID: 96371 RVA: 0x0036AA48 File Offset: 0x00368C48
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsStopCharacter = input.ReadBool();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BC5 RID: 35781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BC6 RID: 35782
		public const int IsStopCharacterFieldNumber = 12;

		// Token: 0x04008BC7 RID: 35783
		private bool isStopCharacter_;

		// Token: 0x04008BC8 RID: 35784
		public const int DurationFieldNumber = 4;

		// Token: 0x04008BC9 RID: 35785
		private int duration_;
	}
}
