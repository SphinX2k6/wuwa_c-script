using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001572 RID: 5490
	[NetMessage(EMessageId.WeatherControlInfoRequest)]
	public sealed class WeatherControlInfoRequest : IMessage<WeatherControlInfoRequest>, IMessage, IEquatable<WeatherControlInfoRequest>, IDeepCloneable<WeatherControlInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D127 RID: 119079 RVA: 0x00435F01 File Offset: 0x00434101
		[NullableContext(1)]
		public static WeatherControlInfoRequest Create()
		{
			return new WeatherControlInfoRequest();
		}

		// Token: 0x1700625E RID: 25182
		// (get) Token: 0x0601D128 RID: 119080 RVA: 0x00435F08 File Offset: 0x00434108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700625F RID: 25183
		// (get) Token: 0x0601D129 RID: 119081 RVA: 0x00435F0B File Offset: 0x0043410B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D12A RID: 119082 RVA: 0x00435F12 File Offset: 0x00434112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoRequest()
		{
		}

		// Token: 0x0601D12B RID: 119083 RVA: 0x00435F1A File Offset: 0x0043411A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoRequest(WeatherControlInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D12C RID: 119084 RVA: 0x00435F33 File Offset: 0x00434133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoRequest Clone()
		{
			return new WeatherControlInfoRequest(this);
		}

		// Token: 0x0601D12D RID: 119085 RVA: 0x00435F3B File Offset: 0x0043413B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlInfoRequest);
		}

		// Token: 0x0601D12E RID: 119086 RVA: 0x00435F49 File Offset: 0x00434149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D12F RID: 119087 RVA: 0x00435F68 File Offset: 0x00434168
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

		// Token: 0x0601D130 RID: 119088 RVA: 0x00435F8E File Offset: 0x0043418E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D131 RID: 119089 RVA: 0x00435F9B File Offset: 0x0043419B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D132 RID: 119090 RVA: 0x00435FA4 File Offset: 0x004341A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D133 RID: 119091 RVA: 0x00435FBC File Offset: 0x004341BC
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

		// Token: 0x0601D134 RID: 119092 RVA: 0x00435FE2 File Offset: 0x004341E2
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

		// Token: 0x0601D135 RID: 119093 RVA: 0x00435FFF File Offset: 0x004341FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D136 RID: 119094 RVA: 0x00436008 File Offset: 0x00434208
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

		// Token: 0x0400A6FD RID: 42749
		private UnknownFieldSet _unknownFields;
	}
}
