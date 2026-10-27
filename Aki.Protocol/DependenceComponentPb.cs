using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C3 RID: 963
	public sealed class DependenceComponentPb : IMessage<DependenceComponentPb>, IMessage, IEquatable<DependenceComponentPb>, IDeepCloneable<DependenceComponentPb>, IBufferMessage
	{
		// Token: 0x06005E27 RID: 24103 RVA: 0x000E4198 File Offset: 0x000E2398
		[NullableContext(1)]
		public static DependenceComponentPb Create()
		{
			return new DependenceComponentPb();
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06005E28 RID: 24104 RVA: 0x000E419F File Offset: 0x000E239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06005E29 RID: 24105 RVA: 0x000E41A2 File Offset: 0x000E23A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DependenceComponentPb.Descriptor;
			}
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x000E41A9 File Offset: 0x000E23A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb()
		{
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x000E41BC File Offset: 0x000E23BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb(DependenceComponentPb other) : this()
		{
			this.dependenceEntityIds_ = other.dependenceEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x000E41E6 File Offset: 0x000E23E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb Clone()
		{
			return new DependenceComponentPb(this);
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x000E41EE File Offset: 0x000E23EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> DependenceEntityIds
		{
			get
			{
				return this.dependenceEntityIds_;
			}
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x000E41F6 File Offset: 0x000E23F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DependenceComponentPb);
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x000E4204 File Offset: 0x000E2404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DependenceComponentPb other)
		{
			return other != null && (other == this || (this.dependenceEntityIds_.Equals(other.dependenceEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x000E4238 File Offset: 0x000E2438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dependenceEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x000E426C File Offset: 0x000E246C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x000E4279 File Offset: 0x000E2479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x000E4282 File Offset: 0x000E2482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dependenceEntityIds_.WriteTo(ref output, DependenceComponentPb._repeated_dependenceEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x000E42AC File Offset: 0x000E24AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dependenceEntityIds_.CalculateSize(DependenceComponentPb._repeated_dependenceEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x000E42E5 File Offset: 0x000E24E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DependenceComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.dependenceEntityIds_.Add(other.dependenceEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x000E4313 File Offset: 0x000E2513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x000E431C File Offset: 0x000E251C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dependenceEntityIds_.AddEntriesFrom(ref input, DependenceComponentPb._repeated_dependenceEntityIds_codec);
				}
			}
		}

		// Token: 0x040036B7 RID: 14007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B8 RID: 14008
		public const int DependenceEntityIdsFieldNumber = 1;

		// Token: 0x040036B9 RID: 14009
		private static readonly FieldCodec<long> _repeated_dependenceEntityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x040036BA RID: 14010
		private readonly RepeatedField<long> dependenceEntityIds_ = new RepeatedField<long>();
	}
}
