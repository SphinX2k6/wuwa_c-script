using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124B RID: 4683
	[NetMessage(EMessageId.SlashAndTowerOverNotify)]
	public sealed class SlashAndTowerOverNotify : IMessage<SlashAndTowerOverNotify>, IMessage, IEquatable<SlashAndTowerOverNotify>, IDeepCloneable<SlashAndTowerOverNotify>, IBufferMessage
	{
		// Token: 0x06018F45 RID: 102213 RVA: 0x003A1A21 File Offset: 0x0039FC21
		[NullableContext(1)]
		public static SlashAndTowerOverNotify Create()
		{
			return new SlashAndTowerOverNotify();
		}

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x06018F46 RID: 102214 RVA: 0x003A1A28 File Offset: 0x0039FC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x06018F47 RID: 102215 RVA: 0x003A1A2B File Offset: 0x0039FC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerOverNotify.Descriptor;
			}
		}

		// Token: 0x06018F48 RID: 102216 RVA: 0x003A1A32 File Offset: 0x0039FC32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerOverNotify()
		{
		}

		// Token: 0x06018F49 RID: 102217 RVA: 0x003A1A3A File Offset: 0x0039FC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerOverNotify(SlashAndTowerOverNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F4A RID: 102218 RVA: 0x003A1A53 File Offset: 0x0039FC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerOverNotify Clone()
		{
			return new SlashAndTowerOverNotify(this);
		}

		// Token: 0x06018F4B RID: 102219 RVA: 0x003A1A5B File Offset: 0x0039FC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerOverNotify);
		}

		// Token: 0x06018F4C RID: 102220 RVA: 0x003A1A69 File Offset: 0x0039FC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerOverNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018F4D RID: 102221 RVA: 0x003A1A88 File Offset: 0x0039FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F4E RID: 102222 RVA: 0x003A1AAE File Offset: 0x0039FCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F4F RID: 102223 RVA: 0x003A1ABB File Offset: 0x0039FCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F50 RID: 102224 RVA: 0x003A1AC4 File Offset: 0x0039FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F51 RID: 102225 RVA: 0x003A1ADC File Offset: 0x0039FCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F52 RID: 102226 RVA: 0x003A1B02 File Offset: 0x0039FD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerOverNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F53 RID: 102227 RVA: 0x003A1B1F File Offset: 0x0039FD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F54 RID: 102228 RVA: 0x003A1B28 File Offset: 0x0039FD28
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009324 RID: 37668
		private UnknownFieldSet _unknownFields;
	}
}
