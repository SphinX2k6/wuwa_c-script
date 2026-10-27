using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C5 RID: 5317
	public sealed class VarComponentPb : IMessage<VarComponentPb>, IMessage, IEquatable<VarComponentPb>, IDeepCloneable<VarComponentPb>, IBufferMessage
	{
		// Token: 0x0601C1D1 RID: 115153 RVA: 0x004103F1 File Offset: 0x0040E5F1
		[NullableContext(1)]
		public static VarComponentPb Create()
		{
			return new VarComponentPb();
		}

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x0601C1D2 RID: 115154 RVA: 0x004103F8 File Offset: 0x0040E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EC0 RID: 24256
		// (get) Token: 0x0601C1D3 RID: 115155 RVA: 0x004103FB File Offset: 0x0040E5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VarComponentPb.Descriptor;
			}
		}

		// Token: 0x0601C1D4 RID: 115156 RVA: 0x00410402 File Offset: 0x0040E602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb()
		{
		}

		// Token: 0x0601C1D5 RID: 115157 RVA: 0x00410415 File Offset: 0x0040E615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb(VarComponentPb other) : this()
		{
			this.vars_ = other.vars_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1D6 RID: 115158 RVA: 0x0041043F File Offset: 0x0040E63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb Clone()
		{
			return new VarComponentPb(this);
		}

		// Token: 0x17005EC1 RID: 24257
		// (get) Token: 0x0601C1D7 RID: 115159 RVA: 0x00410447 File Offset: 0x0040E647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> Vars
		{
			get
			{
				return this.vars_;
			}
		}

		// Token: 0x0601C1D8 RID: 115160 RVA: 0x0041044F File Offset: 0x0040E64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VarComponentPb);
		}

		// Token: 0x0601C1D9 RID: 115161 RVA: 0x0041045D File Offset: 0x0040E65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VarComponentPb other)
		{
			return other != null && (other == this || (this.Vars.Equals(other.Vars) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1DA RID: 115162 RVA: 0x00410490 File Offset: 0x0040E690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Vars.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1DB RID: 115163 RVA: 0x004104C4 File Offset: 0x0040E6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1DC RID: 115164 RVA: 0x004104D1 File Offset: 0x0040E6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1DD RID: 115165 RVA: 0x004104DA File Offset: 0x0040E6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.vars_.WriteTo(ref output, VarComponentPb._map_vars_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1DE RID: 115166 RVA: 0x00410504 File Offset: 0x0040E704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.vars_.CalculateSize(VarComponentPb._map_vars_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1DF RID: 115167 RVA: 0x0041053D File Offset: 0x0040E73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VarComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.vars_.MergeFrom(other.vars_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1E0 RID: 115168 RVA: 0x0041056B File Offset: 0x0040E76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1E1 RID: 115169 RVA: 0x00410574 File Offset: 0x0040E774
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.vars_.AddEntriesFrom(ref input, VarComponentPb._map_vars_codec);
				}
			}
		}

		// Token: 0x0400A15F RID: 41311
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A160 RID: 41312
		public const int VarsFieldNumber = 1;

		// Token: 0x0400A161 RID: 41313
		private static readonly MapField<string, VarDefinePb>.Codec _map_vars_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 10U);

		// Token: 0x0400A162 RID: 41314
		private readonly MapField<string, VarDefinePb> vars_ = new MapField<string, VarDefinePb>();
	}
}
