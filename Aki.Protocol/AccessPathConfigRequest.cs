using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000053 RID: 83
	[NetMessage(EMessageId.AccessPathConfigRequest)]
	public sealed class AccessPathConfigRequest : IMessage<AccessPathConfigRequest>, IMessage, IEquatable<AccessPathConfigRequest>, IDeepCloneable<AccessPathConfigRequest>, IBufferMessage
	{
		// Token: 0x06001515 RID: 5397 RVA: 0x0003833A File Offset: 0x0003653A
		[NullableContext(1)]
		public static AccessPathConfigRequest Create()
		{
			return new AccessPathConfigRequest();
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00038341 File Offset: 0x00036541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00038344 File Offset: 0x00036544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPathConfigRequest.Descriptor;
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0003834B File Offset: 0x0003654B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigRequest()
		{
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00038353 File Offset: 0x00036553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigRequest(AccessPathConfigRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0003836C File Offset: 0x0003656C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigRequest Clone()
		{
			return new AccessPathConfigRequest(this);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00038374 File Offset: 0x00036574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPathConfigRequest);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00038382 File Offset: 0x00036582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPathConfigRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000383A0 File Offset: 0x000365A0
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

		// Token: 0x0600151E RID: 5406 RVA: 0x000383C6 File Offset: 0x000365C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000383D3 File Offset: 0x000365D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000383DC File Offset: 0x000365DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000383F4 File Offset: 0x000365F4
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

		// Token: 0x06001522 RID: 5410 RVA: 0x0003841A File Offset: 0x0003661A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPathConfigRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00038437 File Offset: 0x00036637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00038440 File Offset: 0x00036640
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

		// Token: 0x0400208B RID: 8331
		private UnknownFieldSet _unknownFields;
	}
}
