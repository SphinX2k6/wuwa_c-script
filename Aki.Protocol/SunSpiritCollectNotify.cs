using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B8 RID: 4792
	[NetMessage(EMessageId.SunSpiritCollectNotify)]
	public sealed class SunSpiritCollectNotify : IMessage<SunSpiritCollectNotify>, IMessage, IEquatable<SunSpiritCollectNotify>, IDeepCloneable<SunSpiritCollectNotify>, IBufferMessage
	{
		// Token: 0x06019802 RID: 104450 RVA: 0x003B4D3D File Offset: 0x003B2F3D
		[NullableContext(1)]
		public static SunSpiritCollectNotify Create()
		{
			return new SunSpiritCollectNotify();
		}

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x06019803 RID: 104451 RVA: 0x003B4D44 File Offset: 0x003B2F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x06019804 RID: 104452 RVA: 0x003B4D47 File Offset: 0x003B2F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritCollectNotify.Descriptor;
			}
		}

		// Token: 0x06019805 RID: 104453 RVA: 0x003B4D4E File Offset: 0x003B2F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritCollectNotify()
		{
		}

		// Token: 0x06019806 RID: 104454 RVA: 0x003B4D56 File Offset: 0x003B2F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritCollectNotify(SunSpiritCollectNotify other) : this()
		{
			this.spiritInfo_ = ((other.spiritInfo_ != null) ? other.spiritInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019807 RID: 104455 RVA: 0x003B4D8B File Offset: 0x003B2F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritCollectNotify Clone()
		{
			return new SunSpiritCollectNotify(this);
		}

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x06019808 RID: 104456 RVA: 0x003B4D93 File Offset: 0x003B2F93
		// (set) Token: 0x06019809 RID: 104457 RVA: 0x003B4D9B File Offset: 0x003B2F9B
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

		// Token: 0x0601980A RID: 104458 RVA: 0x003B4DA4 File Offset: 0x003B2FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritCollectNotify);
		}

		// Token: 0x0601980B RID: 104459 RVA: 0x003B4DB2 File Offset: 0x003B2FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritCollectNotify other)
		{
			return other != null && (other == this || (object.Equals(this.SpiritInfo, other.SpiritInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601980C RID: 104460 RVA: 0x003B4DE8 File Offset: 0x003B2FE8
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

		// Token: 0x0601980D RID: 104461 RVA: 0x003B4E24 File Offset: 0x003B3024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601980E RID: 104462 RVA: 0x003B4E31 File Offset: 0x003B3031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601980F RID: 104463 RVA: 0x003B4E3A File Offset: 0x003B303A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.spiritInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SpiritInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019810 RID: 104464 RVA: 0x003B4E6C File Offset: 0x003B306C
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

		// Token: 0x06019811 RID: 104465 RVA: 0x003B4EAC File Offset: 0x003B30AC
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

		// Token: 0x06019812 RID: 104466 RVA: 0x003B4F00 File Offset: 0x003B3100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019813 RID: 104467 RVA: 0x003B4F0C File Offset: 0x003B310C
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
				if (num != 58U)
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

		// Token: 0x040095A0 RID: 38304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095A1 RID: 38305
		public const int SpiritInfoFieldNumber = 7;

		// Token: 0x040095A2 RID: 38306
		private SunSpiritPb spiritInfo_;
	}
}
