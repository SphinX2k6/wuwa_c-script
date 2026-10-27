using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CF RID: 1231
	public sealed class EntranceComponentPb : IMessage<EntranceComponentPb>, IMessage, IEquatable<EntranceComponentPb>, IDeepCloneable<EntranceComponentPb>, IBufferMessage
	{
		// Token: 0x060074F6 RID: 29942 RVA: 0x0011E8BD File Offset: 0x0011CABD
		[NullableContext(1)]
		public static EntranceComponentPb Create()
		{
			return new EntranceComponentPb();
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x060074F7 RID: 29943 RVA: 0x0011E8C4 File Offset: 0x0011CAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x060074F8 RID: 29944 RVA: 0x0011E8C7 File Offset: 0x0011CAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntranceComponentPb.Descriptor;
			}
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x0011E8CE File Offset: 0x0011CACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceComponentPb()
		{
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x0011E8D6 File Offset: 0x0011CAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceComponentPb(EntranceComponentPb other) : this()
		{
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x0011E8FB File Offset: 0x0011CAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceComponentPb Clone()
		{
			return new EntranceComponentPb(this);
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x0011E903 File Offset: 0x0011CB03
		// (set) Token: 0x060074FD RID: 29949 RVA: 0x0011E90B File Offset: 0x0011CB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x0011E914 File Offset: 0x0011CB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntranceComponentPb);
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x0011E922 File Offset: 0x0011CB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntranceComponentPb other)
		{
			return other != null && (other == this || (this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x0011E950 File Offset: 0x0011CB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != EntranceState.NotUnlock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x0011E995 File Offset: 0x0011CB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x0011E9A2 File Offset: 0x0011CBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x0011E9AB File Offset: 0x0011CBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != EntranceState.NotUnlock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x0011E9DC File Offset: 0x0011CBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != EntranceState.NotUnlock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x0011EA1A File Offset: 0x0011CC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntranceComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != EntranceState.NotUnlock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x0011EA4B File Offset: 0x0011CC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x0011EA54 File Offset: 0x0011CC54
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
					this.State = (EntranceState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D92 RID: 15762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D93 RID: 15763
		public const int StateFieldNumber = 1;

		// Token: 0x04003D94 RID: 15764
		private EntranceState state_;
	}
}
