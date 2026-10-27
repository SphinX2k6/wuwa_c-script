using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FC RID: 5372
	[NetMessage(EMessageId.WeatherControlInfoRequest)]
	public sealed class WeatherControlInfoRequest : IMessage<WeatherControlInfoRequest>, IMessage, IEquatable<WeatherControlInfoRequest>, IDeepCloneable<WeatherControlInfoRequest>, IBufferMessage
	{
		// Token: 0x0601C660 RID: 116320 RVA: 0x0041A441 File Offset: 0x00418641
		[NullableContext(1)]
		public static WeatherControlInfoRequest Create()
		{
			return new WeatherControlInfoRequest();
		}

		// Token: 0x17005FBD RID: 24509
		// (get) Token: 0x0601C661 RID: 116321 RVA: 0x0041A448 File Offset: 0x00418648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FBE RID: 24510
		// (get) Token: 0x0601C662 RID: 116322 RVA: 0x0041A44B File Offset: 0x0041864B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601C663 RID: 116323 RVA: 0x0041A452 File Offset: 0x00418652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoRequest()
		{
		}

		// Token: 0x0601C664 RID: 116324 RVA: 0x0041A45A File Offset: 0x0041865A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoRequest(WeatherControlInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C665 RID: 116325 RVA: 0x0041A473 File Offset: 0x00418673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoRequest Clone()
		{
			return new WeatherControlInfoRequest(this);
		}

		// Token: 0x0601C666 RID: 116326 RVA: 0x0041A47B File Offset: 0x0041867B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlInfoRequest);
		}

		// Token: 0x0601C667 RID: 116327 RVA: 0x0041A489 File Offset: 0x00418689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C668 RID: 116328 RVA: 0x0041A4A8 File Offset: 0x004186A8
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

		// Token: 0x0601C669 RID: 116329 RVA: 0x0041A4CE File Offset: 0x004186CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C66A RID: 116330 RVA: 0x0041A4DB File Offset: 0x004186DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C66B RID: 116331 RVA: 0x0041A4E4 File Offset: 0x004186E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C66C RID: 116332 RVA: 0x0041A4FC File Offset: 0x004186FC
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

		// Token: 0x0601C66D RID: 116333 RVA: 0x0041A522 File Offset: 0x00418722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherControlInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C66E RID: 116334 RVA: 0x0041A53F File Offset: 0x0041873F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C66F RID: 116335 RVA: 0x0041A548 File Offset: 0x00418748
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

		// Token: 0x0400A2A4 RID: 41636
		private UnknownFieldSet _unknownFields;
	}
}
