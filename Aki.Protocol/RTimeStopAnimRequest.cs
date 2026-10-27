using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001135 RID: 4405
	[NetMessage(EMessageId.RTimeStopAnimRequest)]
	public sealed class RTimeStopAnimRequest : IMessage<RTimeStopAnimRequest>, IMessage, IEquatable<RTimeStopAnimRequest>, IDeepCloneable<RTimeStopAnimRequest>, IBufferMessage
	{
		// Token: 0x060177EA RID: 96234 RVA: 0x00369964 File Offset: 0x00367B64
		[NullableContext(1)]
		public static RTimeStopAnimRequest Create()
		{
			return new RTimeStopAnimRequest();
		}

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x060177EB RID: 96235 RVA: 0x0036996B File Offset: 0x00367B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x060177EC RID: 96236 RVA: 0x0036996E File Offset: 0x00367B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopAnimRequest.Descriptor;
			}
		}

		// Token: 0x060177ED RID: 96237 RVA: 0x00369975 File Offset: 0x00367B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest()
		{
		}

		// Token: 0x060177EE RID: 96238 RVA: 0x0036997D File Offset: 0x00367B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest(RTimeStopAnimRequest other) : this()
		{
			this.duration_ = other.duration_;
			this.dilation_ = other.dilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177EF RID: 96239 RVA: 0x003699AE File Offset: 0x00367BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest Clone()
		{
			return new RTimeStopAnimRequest(this);
		}

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x060177F0 RID: 96240 RVA: 0x003699B6 File Offset: 0x00367BB6
		// (set) Token: 0x060177F1 RID: 96241 RVA: 0x003699BE File Offset: 0x00367BBE
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

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x060177F2 RID: 96242 RVA: 0x003699C7 File Offset: 0x00367BC7
		// (set) Token: 0x060177F3 RID: 96243 RVA: 0x003699CF File Offset: 0x00367BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Dilation
		{
			get
			{
				return this.dilation_;
			}
			set
			{
				this.dilation_ = value;
			}
		}

		// Token: 0x060177F4 RID: 96244 RVA: 0x003699D8 File Offset: 0x00367BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopAnimRequest);
		}

		// Token: 0x060177F5 RID: 96245 RVA: 0x003699E6 File Offset: 0x00367BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopAnimRequest other)
		{
			return other != null && (other == this || (this.Duration == other.Duration && this.Dilation == other.Dilation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177F6 RID: 96246 RVA: 0x00369A24 File Offset: 0x00367C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.Dilation != 0)
			{
				num ^= this.Dilation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060177F7 RID: 96247 RVA: 0x00369A7C File Offset: 0x00367C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177F8 RID: 96248 RVA: 0x00369A89 File Offset: 0x00367C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177F9 RID: 96249 RVA: 0x00369A94 File Offset: 0x00367C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Dilation != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Dilation);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060177FA RID: 96250 RVA: 0x00369AF0 File Offset: 0x00367CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.Dilation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060177FB RID: 96251 RVA: 0x00369B48 File Offset: 0x00367D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopAnimRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.Dilation != 0)
			{
				this.Dilation = other.Dilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060177FC RID: 96252 RVA: 0x00369B98 File Offset: 0x00367D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177FD RID: 96253 RVA: 0x00369BA4 File Offset: 0x00367DA4
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
					if (num != 80U)
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
					this.Dilation = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BA9 RID: 35753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BAA RID: 35754
		public const int DurationFieldNumber = 10;

		// Token: 0x04008BAB RID: 35755
		private int duration_;

		// Token: 0x04008BAC RID: 35756
		public const int DilationFieldNumber = 6;

		// Token: 0x04008BAD RID: 35757
		private int dilation_;
	}
}
