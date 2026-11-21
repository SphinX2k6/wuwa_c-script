using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153B RID: 5435
	public sealed class VarComponentPb : IMessage<VarComponentPb>, IMessage, IEquatable<VarComponentPb>, IDeepCloneable<VarComponentPb>, IBufferMessage
	{
		// Token: 0x0601CC98 RID: 117912 RVA: 0x0042BEAD File Offset: 0x0042A0AD
		[NullableContext(1)]
		public static VarComponentPb Create()
		{
			return new VarComponentPb();
		}

		// Token: 0x17006160 RID: 24928
		// (get) Token: 0x0601CC99 RID: 117913 RVA: 0x0042BEB4 File Offset: 0x0042A0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x0601CC9A RID: 117914 RVA: 0x0042BEB7 File Offset: 0x0042A0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VarComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CC9B RID: 117915 RVA: 0x0042BEBE File Offset: 0x0042A0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb()
		{
		}

		// Token: 0x0601CC9C RID: 117916 RVA: 0x0042BED1 File Offset: 0x0042A0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb(VarComponentPb other) : this()
		{
			this.vars_ = other.vars_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC9D RID: 117917 RVA: 0x0042BEFB File Offset: 0x0042A0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb Clone()
		{
			return new VarComponentPb(this);
		}

		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x0601CC9E RID: 117918 RVA: 0x0042BF03 File Offset: 0x0042A103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> Vars
		{
			get
			{
				return this.vars_;
			}
		}

		// Token: 0x0601CC9F RID: 117919 RVA: 0x0042BF0B File Offset: 0x0042A10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VarComponentPb);
		}

		// Token: 0x0601CCA0 RID: 117920 RVA: 0x0042BF19 File Offset: 0x0042A119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VarComponentPb other)
		{
			return other != null && (other == this || (this.Vars.Equals(other.Vars) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CCA1 RID: 117921 RVA: 0x0042BF4C File Offset: 0x0042A14C
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

		// Token: 0x0601CCA2 RID: 117922 RVA: 0x0042BF80 File Offset: 0x0042A180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CCA3 RID: 117923 RVA: 0x0042BF8D File Offset: 0x0042A18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CCA4 RID: 117924 RVA: 0x0042BF96 File Offset: 0x0042A196
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

		// Token: 0x0601CCA5 RID: 117925 RVA: 0x0042BFC0 File Offset: 0x0042A1C0
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

		// Token: 0x0601CCA6 RID: 117926 RVA: 0x0042BFF9 File Offset: 0x0042A1F9
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

		// Token: 0x0601CCA7 RID: 117927 RVA: 0x0042C027 File Offset: 0x0042A227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CCA8 RID: 117928 RVA: 0x0042C030 File Offset: 0x0042A230
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

		// Token: 0x0400A5B8 RID: 42424
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5B9 RID: 42425
		public const int VarsFieldNumber = 1;

		// Token: 0x0400A5BA RID: 42426
		private static readonly MapField<string, VarDefinePb>.Codec _map_vars_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 10U);

		// Token: 0x0400A5BB RID: 42427
		private readonly MapField<string, VarDefinePb> vars_ = new MapField<string, VarDefinePb>();
	}
}
