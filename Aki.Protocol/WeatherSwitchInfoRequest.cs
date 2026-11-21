using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001578 RID: 5496
	[NetMessage(EMessageId.WeatherSwitchInfoRequest)]
	public sealed class WeatherSwitchInfoRequest : IMessage<WeatherSwitchInfoRequest>, IMessage, IEquatable<WeatherSwitchInfoRequest>, IDeepCloneable<WeatherSwitchInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D199 RID: 119193 RVA: 0x00436C84 File Offset: 0x00434E84
		[NullableContext(1)]
		public static WeatherSwitchInfoRequest Create()
		{
			return new WeatherSwitchInfoRequest();
		}

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x0601D19A RID: 119194 RVA: 0x00436C8B File Offset: 0x00434E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006274 RID: 25204
		// (get) Token: 0x0601D19B RID: 119195 RVA: 0x00436C8E File Offset: 0x00434E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherSwitchInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D19C RID: 119196 RVA: 0x00436C95 File Offset: 0x00434E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoRequest()
		{
		}

		// Token: 0x0601D19D RID: 119197 RVA: 0x00436C9D File Offset: 0x00434E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoRequest(WeatherSwitchInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D19E RID: 119198 RVA: 0x00436CB6 File Offset: 0x00434EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoRequest Clone()
		{
			return new WeatherSwitchInfoRequest(this);
		}

		// Token: 0x0601D19F RID: 119199 RVA: 0x00436CBE File Offset: 0x00434EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherSwitchInfoRequest);
		}

		// Token: 0x0601D1A0 RID: 119200 RVA: 0x00436CCC File Offset: 0x00434ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherSwitchInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D1A1 RID: 119201 RVA: 0x00436CEC File Offset: 0x00434EEC
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

		// Token: 0x0601D1A2 RID: 119202 RVA: 0x00436D12 File Offset: 0x00434F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1A3 RID: 119203 RVA: 0x00436D1F File Offset: 0x00434F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1A4 RID: 119204 RVA: 0x00436D28 File Offset: 0x00434F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D1A5 RID: 119205 RVA: 0x00436D40 File Offset: 0x00434F40
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

		// Token: 0x0601D1A6 RID: 119206 RVA: 0x00436D66 File Offset: 0x00434F66
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

		// Token: 0x0601D1A7 RID: 119207 RVA: 0x00436D83 File Offset: 0x00434F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1A8 RID: 119208 RVA: 0x00436D8C File Offset: 0x00434F8C
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

		// Token: 0x0400A716 RID: 42774
		private UnknownFieldSet _unknownFields;
	}
}
