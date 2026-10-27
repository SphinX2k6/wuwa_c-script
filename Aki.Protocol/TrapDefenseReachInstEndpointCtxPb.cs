using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143A RID: 5178
	public sealed class TrapDefenseReachInstEndpointCtxPb : IMessage<TrapDefenseReachInstEndpointCtxPb>, IMessage, IEquatable<TrapDefenseReachInstEndpointCtxPb>, IDeepCloneable<TrapDefenseReachInstEndpointCtxPb>, IBufferMessage
	{
		// Token: 0x0601B6DE RID: 112350 RVA: 0x003F8A75 File Offset: 0x003F6C75
		[NullableContext(1)]
		public static TrapDefenseReachInstEndpointCtxPb Create()
		{
			return new TrapDefenseReachInstEndpointCtxPb();
		}

		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x0601B6DF RID: 112351 RVA: 0x003F8A7C File Offset: 0x003F6C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x0601B6E0 RID: 112352 RVA: 0x003F8A7F File Offset: 0x003F6C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseReachInstEndpointCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B6E1 RID: 112353 RVA: 0x003F8A86 File Offset: 0x003F6C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb()
		{
		}

		// Token: 0x0601B6E2 RID: 112354 RVA: 0x003F8A8E File Offset: 0x003F6C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb(TrapDefenseReachInstEndpointCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6E3 RID: 112355 RVA: 0x003F8AA7 File Offset: 0x003F6CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb Clone()
		{
			return new TrapDefenseReachInstEndpointCtxPb(this);
		}

		// Token: 0x0601B6E4 RID: 112356 RVA: 0x003F8AAF File Offset: 0x003F6CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseReachInstEndpointCtxPb);
		}

		// Token: 0x0601B6E5 RID: 112357 RVA: 0x003F8ABD File Offset: 0x003F6CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseReachInstEndpointCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B6E6 RID: 112358 RVA: 0x003F8ADC File Offset: 0x003F6CDC
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

		// Token: 0x0601B6E7 RID: 112359 RVA: 0x003F8B02 File Offset: 0x003F6D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6E8 RID: 112360 RVA: 0x003F8B0F File Offset: 0x003F6D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6E9 RID: 112361 RVA: 0x003F8B18 File Offset: 0x003F6D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6EA RID: 112362 RVA: 0x003F8B30 File Offset: 0x003F6D30
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

		// Token: 0x0601B6EB RID: 112363 RVA: 0x003F8B56 File Offset: 0x003F6D56
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

		// Token: 0x0601B6EC RID: 112364 RVA: 0x003F8B73 File Offset: 0x003F6D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6ED RID: 112365 RVA: 0x003F8B7C File Offset: 0x003F6D7C
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

		// Token: 0x04009E49 RID: 40521
		private UnknownFieldSet _unknownFields;
	}
}
