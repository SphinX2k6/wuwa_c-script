using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001502 RID: 5378
	[NetMessage(EMessageId.WeatherSwitchInfoRequest)]
	public sealed class WeatherSwitchInfoRequest : IMessage<WeatherSwitchInfoRequest>, IMessage, IEquatable<WeatherSwitchInfoRequest>, IDeepCloneable<WeatherSwitchInfoRequest>, IBufferMessage
	{
		// Token: 0x0601C6D2 RID: 116434 RVA: 0x0041B1C4 File Offset: 0x004193C4
		[NullableContext(1)]
		public static WeatherSwitchInfoRequest Create()
		{
			return new WeatherSwitchInfoRequest();
		}

		// Token: 0x17005FD2 RID: 24530
		// (get) Token: 0x0601C6D3 RID: 116435 RVA: 0x0041B1CB File Offset: 0x004193CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FD3 RID: 24531
		// (get) Token: 0x0601C6D4 RID: 116436 RVA: 0x0041B1CE File Offset: 0x004193CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherSwitchInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601C6D5 RID: 116437 RVA: 0x0041B1D5 File Offset: 0x004193D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoRequest()
		{
		}

		// Token: 0x0601C6D6 RID: 116438 RVA: 0x0041B1DD File Offset: 0x004193DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoRequest(WeatherSwitchInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6D7 RID: 116439 RVA: 0x0041B1F6 File Offset: 0x004193F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoRequest Clone()
		{
			return new WeatherSwitchInfoRequest(this);
		}

		// Token: 0x0601C6D8 RID: 116440 RVA: 0x0041B1FE File Offset: 0x004193FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherSwitchInfoRequest);
		}

		// Token: 0x0601C6D9 RID: 116441 RVA: 0x0041B20C File Offset: 0x0041940C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherSwitchInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C6DA RID: 116442 RVA: 0x0041B22C File Offset: 0x0041942C
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

		// Token: 0x0601C6DB RID: 116443 RVA: 0x0041B252 File Offset: 0x00419452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6DC RID: 116444 RVA: 0x0041B25F File Offset: 0x0041945F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6DD RID: 116445 RVA: 0x0041B268 File Offset: 0x00419468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6DE RID: 116446 RVA: 0x0041B280 File Offset: 0x00419480
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

		// Token: 0x0601C6DF RID: 116447 RVA: 0x0041B2A6 File Offset: 0x004194A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherSwitchInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C6E0 RID: 116448 RVA: 0x0041B2C3 File Offset: 0x004194C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6E1 RID: 116449 RVA: 0x0041B2CC File Offset: 0x004194CC
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

		// Token: 0x0400A2BD RID: 41661
		private UnknownFieldSet _unknownFields;
	}
}
