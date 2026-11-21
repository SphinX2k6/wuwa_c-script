using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C9 RID: 5321
	public sealed class TrapDefenseTechParam : IMessage<TrapDefenseTechParam>, IMessage, IEquatable<TrapDefenseTechParam>, IDeepCloneable<TrapDefenseTechParam>, IBufferMessage
	{
		// Token: 0x0601C3A5 RID: 115621 RVA: 0x00418E95 File Offset: 0x00417095
		[NullableContext(1)]
		public static TrapDefenseTechParam Create()
		{
			return new TrapDefenseTechParam();
		}

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x0601C3A6 RID: 115622 RVA: 0x00418E9C File Offset: 0x0041709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x0601C3A7 RID: 115623 RVA: 0x00418E9F File Offset: 0x0041709F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechParam.Descriptor;
			}
		}

		// Token: 0x0601C3A8 RID: 115624 RVA: 0x00418EA6 File Offset: 0x004170A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam()
		{
		}

		// Token: 0x0601C3A9 RID: 115625 RVA: 0x00418EB9 File Offset: 0x004170B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam(TrapDefenseTechParam other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3AA RID: 115626 RVA: 0x00418EE3 File Offset: 0x004170E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam Clone()
		{
			return new TrapDefenseTechParam(this);
		}

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x0601C3AB RID: 115627 RVA: 0x00418EEB File Offset: 0x004170EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601C3AC RID: 115628 RVA: 0x00418EF3 File Offset: 0x004170F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechParam);
		}

		// Token: 0x0601C3AD RID: 115629 RVA: 0x00418F01 File Offset: 0x00417101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechParam other)
		{
			return other != null && (other == this || (this.Params.Equals(other.Params) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3AE RID: 115630 RVA: 0x00418F34 File Offset: 0x00417134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Params.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C3AF RID: 115631 RVA: 0x00418F68 File Offset: 0x00417168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3B0 RID: 115632 RVA: 0x00418F75 File Offset: 0x00417175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3B1 RID: 115633 RVA: 0x00418F7E File Offset: 0x0041717E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, TrapDefenseTechParam._map_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3B2 RID: 115634 RVA: 0x00418FA8 File Offset: 0x004171A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.params_.CalculateSize(TrapDefenseTechParam._map_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C3B3 RID: 115635 RVA: 0x00418FE1 File Offset: 0x004171E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechParam other)
		{
			if (other == null)
			{
				return;
			}
			this.params_.MergeFrom(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C3B4 RID: 115636 RVA: 0x0041900F File Offset: 0x0041720F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3B5 RID: 115637 RVA: 0x00419018 File Offset: 0x00417218
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
					this.params_.AddEntriesFrom(ref input, TrapDefenseTechParam._map_params_codec);
				}
			}
		}

		// Token: 0x0400A339 RID: 41785
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A33A RID: 41786
		public const int ParamsFieldNumber = 1;

		// Token: 0x0400A33B RID: 41787
		private static readonly MapField<int, int>.Codec _map_params_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x0400A33C RID: 41788
		private readonly MapField<int, int> params_ = new MapField<int, int>();
	}
}
