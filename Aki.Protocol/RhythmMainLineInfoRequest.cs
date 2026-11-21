using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2B RID: 3883
	[NetMessage(EMessageId.RhythmMainLineInfoRequest)]
	public sealed class RhythmMainLineInfoRequest : IMessage<RhythmMainLineInfoRequest>, IMessage, IEquatable<RhythmMainLineInfoRequest>, IDeepCloneable<RhythmMainLineInfoRequest>, IBufferMessage
	{
		// Token: 0x06014CE7 RID: 85223 RVA: 0x003055F5 File Offset: 0x003037F5
		[NullableContext(1)]
		public static RhythmMainLineInfoRequest Create()
		{
			return new RhythmMainLineInfoRequest();
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x06014CE8 RID: 85224 RVA: 0x003055FC File Offset: 0x003037FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x06014CE9 RID: 85225 RVA: 0x003055FF File Offset: 0x003037FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmMainLineInfoRequest.Descriptor;
			}
		}

		// Token: 0x06014CEA RID: 85226 RVA: 0x00305606 File Offset: 0x00303806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoRequest()
		{
		}

		// Token: 0x06014CEB RID: 85227 RVA: 0x0030560E File Offset: 0x0030380E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoRequest(RhythmMainLineInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CEC RID: 85228 RVA: 0x00305627 File Offset: 0x00303827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoRequest Clone()
		{
			return new RhythmMainLineInfoRequest(this);
		}

		// Token: 0x06014CED RID: 85229 RVA: 0x0030562F File Offset: 0x0030382F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmMainLineInfoRequest);
		}

		// Token: 0x06014CEE RID: 85230 RVA: 0x0030563D File Offset: 0x0030383D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmMainLineInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014CEF RID: 85231 RVA: 0x0030565C File Offset: 0x0030385C
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

		// Token: 0x06014CF0 RID: 85232 RVA: 0x00305682 File Offset: 0x00303882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CF1 RID: 85233 RVA: 0x0030568F File Offset: 0x0030388F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CF2 RID: 85234 RVA: 0x00305698 File Offset: 0x00303898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CF3 RID: 85235 RVA: 0x003056B0 File Offset: 0x003038B0
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

		// Token: 0x06014CF4 RID: 85236 RVA: 0x003056D6 File Offset: 0x003038D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmMainLineInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014CF5 RID: 85237 RVA: 0x003056F3 File Offset: 0x003038F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CF6 RID: 85238 RVA: 0x003056FC File Offset: 0x003038FC
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

		// Token: 0x04007E06 RID: 32262
		private UnknownFieldSet _unknownFields;
	}
}
