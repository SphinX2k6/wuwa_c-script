using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001327 RID: 4903
	[NetMessage(EMessageId.SunSpiritCollectNotify)]
	public sealed class SunSpiritCollectNotify : IMessage<SunSpiritCollectNotify>, IMessage, IEquatable<SunSpiritCollectNotify>, IDeepCloneable<SunSpiritCollectNotify>, IBufferMessage
	{
		// Token: 0x0601A238 RID: 107064 RVA: 0x003CF47C File Offset: 0x003CD67C
		[NullableContext(1)]
		public static SunSpiritCollectNotify Create()
		{
			return new SunSpiritCollectNotify();
		}

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x0601A239 RID: 107065 RVA: 0x003CF483 File Offset: 0x003CD683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x0601A23A RID: 107066 RVA: 0x003CF486 File Offset: 0x003CD686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritCollectNotify.Descriptor;
			}
		}

		// Token: 0x0601A23B RID: 107067 RVA: 0x003CF48D File Offset: 0x003CD68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritCollectNotify()
		{
		}

		// Token: 0x0601A23C RID: 107068 RVA: 0x003CF495 File Offset: 0x003CD695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritCollectNotify(SunSpiritCollectNotify other) : this()
		{
			this.spiritInfo_ = ((other.spiritInfo_ != null) ? other.spiritInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A23D RID: 107069 RVA: 0x003CF4CA File Offset: 0x003CD6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritCollectNotify Clone()
		{
			return new SunSpiritCollectNotify(this);
		}

		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x0601A23E RID: 107070 RVA: 0x003CF4D2 File Offset: 0x003CD6D2
		// (set) Token: 0x0601A23F RID: 107071 RVA: 0x003CF4DA File Offset: 0x003CD6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb SpiritInfo
		{
			get
			{
				return this.spiritInfo_;
			}
			set
			{
				this.spiritInfo_ = value;
			}
		}

		// Token: 0x0601A240 RID: 107072 RVA: 0x003CF4E3 File Offset: 0x003CD6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritCollectNotify);
		}

		// Token: 0x0601A241 RID: 107073 RVA: 0x003CF4F1 File Offset: 0x003CD6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritCollectNotify other)
		{
			return other != null && (other == this || (object.Equals(this.SpiritInfo, other.SpiritInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A242 RID: 107074 RVA: 0x003CF524 File Offset: 0x003CD724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.spiritInfo_ != null)
			{
				num ^= this.SpiritInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A243 RID: 107075 RVA: 0x003CF560 File Offset: 0x003CD760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A244 RID: 107076 RVA: 0x003CF56D File Offset: 0x003CD76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A245 RID: 107077 RVA: 0x003CF576 File Offset: 0x003CD776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.spiritInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SpiritInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A246 RID: 107078 RVA: 0x003CF5A8 File Offset: 0x003CD7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.spiritInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpiritInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A247 RID: 107079 RVA: 0x003CF5E8 File Offset: 0x003CD7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritCollectNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.spiritInfo_ != null)
			{
				if (this.spiritInfo_ == null)
				{
					this.SpiritInfo = new SunSpiritPb();
				}
				this.SpiritInfo.MergeFrom(other.SpiritInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A248 RID: 107080 RVA: 0x003CF63C File Offset: 0x003CD83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A249 RID: 107081 RVA: 0x003CF648 File Offset: 0x003CD848
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.spiritInfo_ == null)
					{
						this.SpiritInfo = new SunSpiritPb();
					}
					input.ReadMessage(this.SpiritInfo);
				}
			}
		}

		// Token: 0x040099CA RID: 39370
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099CB RID: 39371
		public const int SpiritInfoFieldNumber = 11;

		// Token: 0x040099CC RID: 39372
		private SunSpiritPb spiritInfo_;
	}
}
