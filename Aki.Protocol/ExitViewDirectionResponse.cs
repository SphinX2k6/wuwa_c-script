using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D8 RID: 1240
	[NetMessage(EMessageId.ExitViewDirectionResponse)]
	public sealed class ExitViewDirectionResponse : IMessage<ExitViewDirectionResponse>, IMessage, IEquatable<ExitViewDirectionResponse>, IDeepCloneable<ExitViewDirectionResponse>, IBufferMessage
	{
		// Token: 0x060075D9 RID: 30169 RVA: 0x0012047E File Offset: 0x0011E67E
		[NullableContext(1)]
		public static ExitViewDirectionResponse Create()
		{
			return new ExitViewDirectionResponse();
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x060075DA RID: 30170 RVA: 0x00120485 File Offset: 0x0011E685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x060075DB RID: 30171 RVA: 0x00120488 File Offset: 0x0011E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitViewDirectionResponse.Descriptor;
			}
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x0012048F File Offset: 0x0011E68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse()
		{
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00120497 File Offset: 0x0011E697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse(ExitViewDirectionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x001204BC File Offset: 0x0011E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse Clone()
		{
			return new ExitViewDirectionResponse(this);
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x060075DF RID: 30175 RVA: 0x001204C4 File Offset: 0x0011E6C4
		// (set) Token: 0x060075E0 RID: 30176 RVA: 0x001204CC File Offset: 0x0011E6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x001204D5 File Offset: 0x0011E6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitViewDirectionResponse);
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x001204E3 File Offset: 0x0011E6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitViewDirectionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00120514 File Offset: 0x0011E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00120559 File Offset: 0x0011E759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00120566 File Offset: 0x0011E766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x0012056F File Offset: 0x0011E76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x001205A4 File Offset: 0x0011E7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x001205E2 File Offset: 0x0011E7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitViewDirectionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00120613 File Offset: 0x0011E813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x0012061C File Offset: 0x0011E81C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E16 RID: 15894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E17 RID: 15895
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003E18 RID: 15896
		private ErrorCode errorCode_;
	}
}
