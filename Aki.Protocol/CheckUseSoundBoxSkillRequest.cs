using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000286 RID: 646
	[NetMessage(EMessageId.CheckUseSoundBoxSkillRequest)]
	public sealed class CheckUseSoundBoxSkillRequest : IMessage<CheckUseSoundBoxSkillRequest>, IMessage, IEquatable<CheckUseSoundBoxSkillRequest>, IDeepCloneable<CheckUseSoundBoxSkillRequest>, IBufferMessage
	{
		// Token: 0x0600438E RID: 17294 RVA: 0x000A5910 File Offset: 0x000A3B10
		[NullableContext(1)]
		public static CheckUseSoundBoxSkillRequest Create()
		{
			return new CheckUseSoundBoxSkillRequest();
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x000A5917 File Offset: 0x000A3B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x000A591A File Offset: 0x000A3B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckUseSoundBoxSkillRequest.Descriptor;
			}
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x000A5921 File Offset: 0x000A3B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillRequest()
		{
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x000A5929 File Offset: 0x000A3B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillRequest(CheckUseSoundBoxSkillRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x000A5942 File Offset: 0x000A3B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillRequest Clone()
		{
			return new CheckUseSoundBoxSkillRequest(this);
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x000A594A File Offset: 0x000A3B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckUseSoundBoxSkillRequest);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x000A5958 File Offset: 0x000A3B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckUseSoundBoxSkillRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x000A5978 File Offset: 0x000A3B78
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

		// Token: 0x06004397 RID: 17303 RVA: 0x000A599E File Offset: 0x000A3B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x000A59AB File Offset: 0x000A3BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x000A59B4 File Offset: 0x000A3BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x000A59CC File Offset: 0x000A3BCC
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

		// Token: 0x0600439B RID: 17307 RVA: 0x000A59F2 File Offset: 0x000A3BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckUseSoundBoxSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000A5A0F File Offset: 0x000A3C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000A5A18 File Offset: 0x000A3C18
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

		// Token: 0x04002E5B RID: 11867
		private UnknownFieldSet _unknownFields;
	}
}
