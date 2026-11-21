using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AD RID: 5293
	public sealed class TrapDefenseReachInstEndpointCtxPb : IMessage<TrapDefenseReachInstEndpointCtxPb>, IMessage, IEquatable<TrapDefenseReachInstEndpointCtxPb>, IDeepCloneable<TrapDefenseReachInstEndpointCtxPb>, IBufferMessage
	{
		// Token: 0x0601C169 RID: 115049 RVA: 0x00413D49 File Offset: 0x00411F49
		[NullableContext(1)]
		public static TrapDefenseReachInstEndpointCtxPb Create()
		{
			return new TrapDefenseReachInstEndpointCtxPb();
		}

		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x0601C16A RID: 115050 RVA: 0x00413D50 File Offset: 0x00411F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x0601C16B RID: 115051 RVA: 0x00413D53 File Offset: 0x00411F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseReachInstEndpointCtxPb.Descriptor;
			}
		}

		// Token: 0x0601C16C RID: 115052 RVA: 0x00413D5A File Offset: 0x00411F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb()
		{
		}

		// Token: 0x0601C16D RID: 115053 RVA: 0x00413D62 File Offset: 0x00411F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb(TrapDefenseReachInstEndpointCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C16E RID: 115054 RVA: 0x00413D7B File Offset: 0x00411F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb Clone()
		{
			return new TrapDefenseReachInstEndpointCtxPb(this);
		}

		// Token: 0x0601C16F RID: 115055 RVA: 0x00413D83 File Offset: 0x00411F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseReachInstEndpointCtxPb);
		}

		// Token: 0x0601C170 RID: 115056 RVA: 0x00413D91 File Offset: 0x00411F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseReachInstEndpointCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C171 RID: 115057 RVA: 0x00413DB0 File Offset: 0x00411FB0
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

		// Token: 0x0601C172 RID: 115058 RVA: 0x00413DD6 File Offset: 0x00411FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C173 RID: 115059 RVA: 0x00413DE3 File Offset: 0x00411FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C174 RID: 115060 RVA: 0x00413DEC File Offset: 0x00411FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C175 RID: 115061 RVA: 0x00413E04 File Offset: 0x00412004
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

		// Token: 0x0601C176 RID: 115062 RVA: 0x00413E2A File Offset: 0x0041202A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseReachInstEndpointCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C177 RID: 115063 RVA: 0x00413E47 File Offset: 0x00412047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C178 RID: 115064 RVA: 0x00413E50 File Offset: 0x00412050
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

		// Token: 0x0400A290 RID: 41616
		private UnknownFieldSet _unknownFields;
	}
}
