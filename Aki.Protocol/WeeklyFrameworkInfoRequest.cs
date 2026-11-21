using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001581 RID: 5505
	[NetMessage(EMessageId.WeeklyFrameworkInfoRequest)]
	public sealed class WeeklyFrameworkInfoRequest : IMessage<WeeklyFrameworkInfoRequest>, IMessage, IEquatable<WeeklyFrameworkInfoRequest>, IDeepCloneable<WeeklyFrameworkInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D25A RID: 119386 RVA: 0x0043887D File Offset: 0x00436A7D
		[NullableContext(1)]
		public static WeeklyFrameworkInfoRequest Create()
		{
			return new WeeklyFrameworkInfoRequest();
		}

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x0601D25B RID: 119387 RVA: 0x00438884 File Offset: 0x00436A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x0601D25C RID: 119388 RVA: 0x00438887 File Offset: 0x00436A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D25D RID: 119389 RVA: 0x0043888E File Offset: 0x00436A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoRequest()
		{
		}

		// Token: 0x0601D25E RID: 119390 RVA: 0x00438896 File Offset: 0x00436A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoRequest(WeeklyFrameworkInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D25F RID: 119391 RVA: 0x004388AF File Offset: 0x00436AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoRequest Clone()
		{
			return new WeeklyFrameworkInfoRequest(this);
		}

		// Token: 0x0601D260 RID: 119392 RVA: 0x004388B7 File Offset: 0x00436AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfoRequest);
		}

		// Token: 0x0601D261 RID: 119393 RVA: 0x004388C5 File Offset: 0x00436AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D262 RID: 119394 RVA: 0x004388E4 File Offset: 0x00436AE4
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

		// Token: 0x0601D263 RID: 119395 RVA: 0x0043890A File Offset: 0x00436B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D264 RID: 119396 RVA: 0x00438917 File Offset: 0x00436B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D265 RID: 119397 RVA: 0x00438920 File Offset: 0x00436B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D266 RID: 119398 RVA: 0x00438938 File Offset: 0x00436B38
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

		// Token: 0x0601D267 RID: 119399 RVA: 0x0043895E File Offset: 0x00436B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D268 RID: 119400 RVA: 0x0043897B File Offset: 0x00436B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D269 RID: 119401 RVA: 0x00438984 File Offset: 0x00436B84
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

		// Token: 0x0400A758 RID: 42840
		private UnknownFieldSet _unknownFields;
	}
}
