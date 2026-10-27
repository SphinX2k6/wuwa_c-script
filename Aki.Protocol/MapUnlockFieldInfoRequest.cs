using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A7 RID: 2471
	[NetMessage(EMessageId.MapUnlockFieldInfoRequest)]
	public sealed class MapUnlockFieldInfoRequest : IMessage<MapUnlockFieldInfoRequest>, IMessage, IEquatable<MapUnlockFieldInfoRequest>, IDeepCloneable<MapUnlockFieldInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D8E9 RID: 55529 RVA: 0x001FDC49 File Offset: 0x001FBE49
		[NullableContext(1)]
		public static MapUnlockFieldInfoRequest Create()
		{
			return new MapUnlockFieldInfoRequest();
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600D8EA RID: 55530 RVA: 0x001FDC50 File Offset: 0x001FBE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600D8EB RID: 55531 RVA: 0x001FDC53 File Offset: 0x001FBE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapUnlockFieldInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D8EC RID: 55532 RVA: 0x001FDC5A File Offset: 0x001FBE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoRequest()
		{
		}

		// Token: 0x0600D8ED RID: 55533 RVA: 0x001FDC62 File Offset: 0x001FBE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoRequest(MapUnlockFieldInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x001FDC7B File Offset: 0x001FBE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoRequest Clone()
		{
			return new MapUnlockFieldInfoRequest(this);
		}

		// Token: 0x0600D8EF RID: 55535 RVA: 0x001FDC83 File Offset: 0x001FBE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapUnlockFieldInfoRequest);
		}

		// Token: 0x0600D8F0 RID: 55536 RVA: 0x001FDC91 File Offset: 0x001FBE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapUnlockFieldInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D8F1 RID: 55537 RVA: 0x001FDCB0 File Offset: 0x001FBEB0
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

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x001FDCD6 File Offset: 0x001FBED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x001FDCE3 File Offset: 0x001FBEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x001FDCEC File Offset: 0x001FBEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8F5 RID: 55541 RVA: 0x001FDD04 File Offset: 0x001FBF04
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

		// Token: 0x0600D8F6 RID: 55542 RVA: 0x001FDD2A File Offset: 0x001FBF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapUnlockFieldInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8F7 RID: 55543 RVA: 0x001FDD47 File Offset: 0x001FBF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8F8 RID: 55544 RVA: 0x001FDD50 File Offset: 0x001FBF50
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

		// Token: 0x04005A44 RID: 23108
		private UnknownFieldSet _unknownFields;
	}
}
