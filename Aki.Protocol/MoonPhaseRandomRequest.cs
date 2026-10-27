using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A10 RID: 2576
	[NetMessage(EMessageId.MoonPhaseRandomRequest)]
	public sealed class MoonPhaseRandomRequest : IMessage<MoonPhaseRandomRequest>, IMessage, IEquatable<MoonPhaseRandomRequest>, IDeepCloneable<MoonPhaseRandomRequest>, IBufferMessage
	{
		// Token: 0x0600E15E RID: 57694 RVA: 0x002103D3 File Offset: 0x0020E5D3
		[NullableContext(1)]
		public static MoonPhaseRandomRequest Create()
		{
			return new MoonPhaseRandomRequest();
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0600E15F RID: 57695 RVA: 0x002103DA File Offset: 0x0020E5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x002103DD File Offset: 0x0020E5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRandomRequest.Descriptor;
			}
		}

		// Token: 0x0600E161 RID: 57697 RVA: 0x002103E4 File Offset: 0x0020E5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomRequest()
		{
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x002103EC File Offset: 0x0020E5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomRequest(MoonPhaseRandomRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E163 RID: 57699 RVA: 0x00210405 File Offset: 0x0020E605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomRequest Clone()
		{
			return new MoonPhaseRandomRequest(this);
		}

		// Token: 0x0600E164 RID: 57700 RVA: 0x0021040D File Offset: 0x0020E60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRandomRequest);
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x0021041B File Offset: 0x0020E61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRandomRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x0021043C File Offset: 0x0020E63C
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

		// Token: 0x0600E167 RID: 57703 RVA: 0x00210462 File Offset: 0x0020E662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x0021046F File Offset: 0x0020E66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x00210478 File Offset: 0x0020E678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x00210490 File Offset: 0x0020E690
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

		// Token: 0x0600E16B RID: 57707 RVA: 0x002104B6 File Offset: 0x0020E6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRandomRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E16C RID: 57708 RVA: 0x002104D3 File Offset: 0x0020E6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E16D RID: 57709 RVA: 0x002104DC File Offset: 0x0020E6DC
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

		// Token: 0x04005CA7 RID: 23719
		private UnknownFieldSet _unknownFields;
	}
}
