using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D2 RID: 5330
	public sealed class VehiclePb : IMessage<VehiclePb>, IMessage, IEquatable<VehiclePb>, IDeepCloneable<VehiclePb>, IBufferMessage
	{
		// Token: 0x0601C2F7 RID: 115447 RVA: 0x00412DA5 File Offset: 0x00410FA5
		[NullableContext(1)]
		public static VehiclePb Create()
		{
			return new VehiclePb();
		}

		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x0601C2F8 RID: 115448 RVA: 0x00412DAC File Offset: 0x00410FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x0601C2F9 RID: 115449 RVA: 0x00412DAF File Offset: 0x00410FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePb.Descriptor;
			}
		}

		// Token: 0x0601C2FA RID: 115450 RVA: 0x00412DB6 File Offset: 0x00410FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb()
		{
		}

		// Token: 0x0601C2FB RID: 115451 RVA: 0x00412DBE File Offset: 0x00410FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb(VehiclePb other) : this()
		{
			this.source_ = other.source_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2FC RID: 115452 RVA: 0x00412DE3 File Offset: 0x00410FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb Clone()
		{
			return new VehiclePb(this);
		}

		// Token: 0x17005F06 RID: 24326
		// (get) Token: 0x0601C2FD RID: 115453 RVA: 0x00412DEB File Offset: 0x00410FEB
		// (set) Token: 0x0601C2FE RID: 115454 RVA: 0x00412DF3 File Offset: 0x00410FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleSource Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x0601C2FF RID: 115455 RVA: 0x00412DFC File Offset: 0x00410FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePb);
		}

		// Token: 0x0601C300 RID: 115456 RVA: 0x00412E0A File Offset: 0x0041100A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePb other)
		{
			return other != null && (other == this || (this.Source == other.Source && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C301 RID: 115457 RVA: 0x00412E38 File Offset: 0x00411038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Source != VehicleSource.None)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C302 RID: 115458 RVA: 0x00412E7D File Offset: 0x0041107D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C303 RID: 115459 RVA: 0x00412E8A File Offset: 0x0041108A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C304 RID: 115460 RVA: 0x00412E93 File Offset: 0x00411093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Source != VehicleSource.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Source);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C305 RID: 115461 RVA: 0x00412EC4 File Offset: 0x004110C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Source != VehicleSource.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C306 RID: 115462 RVA: 0x00412F02 File Offset: 0x00411102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Source != VehicleSource.None)
			{
				this.Source = other.Source;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C307 RID: 115463 RVA: 0x00412F33 File Offset: 0x00411133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C308 RID: 115464 RVA: 0x00412F3C File Offset: 0x0041113C
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
					this.Source = (VehicleSource)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1A7 RID: 41383
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1A8 RID: 41384
		public const int SourceFieldNumber = 1;

		// Token: 0x0400A1A9 RID: 41385
		private VehicleSource source_;
	}
}
