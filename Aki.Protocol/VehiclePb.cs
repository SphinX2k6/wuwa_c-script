using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001548 RID: 5448
	public sealed class VehiclePb : IMessage<VehiclePb>, IMessage, IEquatable<VehiclePb>, IDeepCloneable<VehiclePb>, IBufferMessage
	{
		// Token: 0x0601CDBE RID: 118206 RVA: 0x0042E861 File Offset: 0x0042CA61
		[NullableContext(1)]
		public static VehiclePb Create()
		{
			return new VehiclePb();
		}

		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x0601CDBF RID: 118207 RVA: 0x0042E868 File Offset: 0x0042CA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x0601CDC0 RID: 118208 RVA: 0x0042E86B File Offset: 0x0042CA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePb.Descriptor;
			}
		}

		// Token: 0x0601CDC1 RID: 118209 RVA: 0x0042E872 File Offset: 0x0042CA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb()
		{
		}

		// Token: 0x0601CDC2 RID: 118210 RVA: 0x0042E87A File Offset: 0x0042CA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb(VehiclePb other) : this()
		{
			this.source_ = other.source_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CDC3 RID: 118211 RVA: 0x0042E89F File Offset: 0x0042CA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb Clone()
		{
			return new VehiclePb(this);
		}

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x0601CDC4 RID: 118212 RVA: 0x0042E8A7 File Offset: 0x0042CAA7
		// (set) Token: 0x0601CDC5 RID: 118213 RVA: 0x0042E8AF File Offset: 0x0042CAAF
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

		// Token: 0x0601CDC6 RID: 118214 RVA: 0x0042E8B8 File Offset: 0x0042CAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePb);
		}

		// Token: 0x0601CDC7 RID: 118215 RVA: 0x0042E8C6 File Offset: 0x0042CAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePb other)
		{
			return other != null && (other == this || (this.Source == other.Source && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CDC8 RID: 118216 RVA: 0x0042E8F4 File Offset: 0x0042CAF4
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

		// Token: 0x0601CDC9 RID: 118217 RVA: 0x0042E939 File Offset: 0x0042CB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CDCA RID: 118218 RVA: 0x0042E946 File Offset: 0x0042CB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CDCB RID: 118219 RVA: 0x0042E94F File Offset: 0x0042CB4F
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

		// Token: 0x0601CDCC RID: 118220 RVA: 0x0042E980 File Offset: 0x0042CB80
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

		// Token: 0x0601CDCD RID: 118221 RVA: 0x0042E9BE File Offset: 0x0042CBBE
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

		// Token: 0x0601CDCE RID: 118222 RVA: 0x0042E9EF File Offset: 0x0042CBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CDCF RID: 118223 RVA: 0x0042E9F8 File Offset: 0x0042CBF8
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

		// Token: 0x0400A600 RID: 42496
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A601 RID: 42497
		public const int SourceFieldNumber = 1;

		// Token: 0x0400A602 RID: 42498
		private VehicleSource source_;
	}
}
