using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096A RID: 2410
	[NetMessage(EMessageId.LstBattleRecordRequest)]
	public sealed class LstBattleRecordRequest : IMessage<LstBattleRecordRequest>, IMessage, IEquatable<LstBattleRecordRequest>, IDeepCloneable<LstBattleRecordRequest>, IBufferMessage
	{
		// Token: 0x0600D43A RID: 54330 RVA: 0x001F4140 File Offset: 0x001F2340
		[NullableContext(1)]
		public static LstBattleRecordRequest Create()
		{
			return new LstBattleRecordRequest();
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600D43B RID: 54331 RVA: 0x001F4147 File Offset: 0x001F2347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0600D43C RID: 54332 RVA: 0x001F414A File Offset: 0x001F234A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LstBattleRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x001F4151 File Offset: 0x001F2351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordRequest()
		{
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x001F4159 File Offset: 0x001F2359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordRequest(LstBattleRecordRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D43F RID: 54335 RVA: 0x001F4172 File Offset: 0x001F2372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordRequest Clone()
		{
			return new LstBattleRecordRequest(this);
		}

		// Token: 0x0600D440 RID: 54336 RVA: 0x001F417A File Offset: 0x001F237A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LstBattleRecordRequest);
		}

		// Token: 0x0600D441 RID: 54337 RVA: 0x001F4188 File Offset: 0x001F2388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LstBattleRecordRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D442 RID: 54338 RVA: 0x001F41A8 File Offset: 0x001F23A8
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

		// Token: 0x0600D443 RID: 54339 RVA: 0x001F41CE File Offset: 0x001F23CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D444 RID: 54340 RVA: 0x001F41DB File Offset: 0x001F23DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x001F41E4 File Offset: 0x001F23E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D446 RID: 54342 RVA: 0x001F41FC File Offset: 0x001F23FC
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

		// Token: 0x0600D447 RID: 54343 RVA: 0x001F4222 File Offset: 0x001F2422
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

		// Token: 0x0600D448 RID: 54344 RVA: 0x001F423F File Offset: 0x001F243F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D449 RID: 54345 RVA: 0x001F4248 File Offset: 0x001F2448
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

		// Token: 0x04005914 RID: 22804
		private UnknownFieldSet _unknownFields;
	}
}
