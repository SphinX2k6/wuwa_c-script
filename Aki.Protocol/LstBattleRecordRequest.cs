using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000959 RID: 2393
	[NetMessage(EMessageId.LstBattleRecordRequest)]
	public sealed class LstBattleRecordRequest : IMessage<LstBattleRecordRequest>, IMessage, IEquatable<LstBattleRecordRequest>, IDeepCloneable<LstBattleRecordRequest>, IBufferMessage
	{
		// Token: 0x0600D320 RID: 54048 RVA: 0x001F1F58 File Offset: 0x001F0158
		[NullableContext(1)]
		public static LstBattleRecordRequest Create()
		{
			return new LstBattleRecordRequest();
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600D321 RID: 54049 RVA: 0x001F1F5F File Offset: 0x001F015F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0600D322 RID: 54050 RVA: 0x001F1F62 File Offset: 0x001F0162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LstBattleRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600D323 RID: 54051 RVA: 0x001F1F69 File Offset: 0x001F0169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordRequest()
		{
		}

		// Token: 0x0600D324 RID: 54052 RVA: 0x001F1F71 File Offset: 0x001F0171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordRequest(LstBattleRecordRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D325 RID: 54053 RVA: 0x001F1F8A File Offset: 0x001F018A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordRequest Clone()
		{
			return new LstBattleRecordRequest(this);
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x001F1F92 File Offset: 0x001F0192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LstBattleRecordRequest);
		}

		// Token: 0x0600D327 RID: 54055 RVA: 0x001F1FA0 File Offset: 0x001F01A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LstBattleRecordRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D328 RID: 54056 RVA: 0x001F1FC0 File Offset: 0x001F01C0
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

		// Token: 0x0600D329 RID: 54057 RVA: 0x001F1FE6 File Offset: 0x001F01E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D32A RID: 54058 RVA: 0x001F1FF3 File Offset: 0x001F01F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D32B RID: 54059 RVA: 0x001F1FFC File Offset: 0x001F01FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D32C RID: 54060 RVA: 0x001F2014 File Offset: 0x001F0214
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

		// Token: 0x0600D32D RID: 54061 RVA: 0x001F203A File Offset: 0x001F023A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LstBattleRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D32E RID: 54062 RVA: 0x001F2057 File Offset: 0x001F0257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D32F RID: 54063 RVA: 0x001F2060 File Offset: 0x001F0260
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

		// Token: 0x0400591D RID: 22813
		private UnknownFieldSet _unknownFields;
	}
}
