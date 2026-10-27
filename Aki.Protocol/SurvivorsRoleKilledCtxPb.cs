using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E2 RID: 4834
	public sealed class SurvivorsRoleKilledCtxPb : IMessage<SurvivorsRoleKilledCtxPb>, IMessage, IEquatable<SurvivorsRoleKilledCtxPb>, IDeepCloneable<SurvivorsRoleKilledCtxPb>, IBufferMessage
	{
		// Token: 0x06019B64 RID: 105316 RVA: 0x003BCCF4 File Offset: 0x003BAEF4
		[NullableContext(1)]
		public static SurvivorsRoleKilledCtxPb Create()
		{
			return new SurvivorsRoleKilledCtxPb();
		}

		// Token: 0x170056BD RID: 22205
		// (get) Token: 0x06019B65 RID: 105317 RVA: 0x003BCCFB File Offset: 0x003BAEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056BE RID: 22206
		// (get) Token: 0x06019B66 RID: 105318 RVA: 0x003BCCFE File Offset: 0x003BAEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRoleKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x06019B67 RID: 105319 RVA: 0x003BCD05 File Offset: 0x003BAF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb()
		{
		}

		// Token: 0x06019B68 RID: 105320 RVA: 0x003BCD0D File Offset: 0x003BAF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb(SurvivorsRoleKilledCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B69 RID: 105321 RVA: 0x003BCD26 File Offset: 0x003BAF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb Clone()
		{
			return new SurvivorsRoleKilledCtxPb(this);
		}

		// Token: 0x06019B6A RID: 105322 RVA: 0x003BCD2E File Offset: 0x003BAF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRoleKilledCtxPb);
		}

		// Token: 0x06019B6B RID: 105323 RVA: 0x003BCD3C File Offset: 0x003BAF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRoleKilledCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019B6C RID: 105324 RVA: 0x003BCD5C File Offset: 0x003BAF5C
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

		// Token: 0x06019B6D RID: 105325 RVA: 0x003BCD82 File Offset: 0x003BAF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B6E RID: 105326 RVA: 0x003BCD8F File Offset: 0x003BAF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B6F RID: 105327 RVA: 0x003BCD98 File Offset: 0x003BAF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B70 RID: 105328 RVA: 0x003BCDB0 File Offset: 0x003BAFB0
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

		// Token: 0x06019B71 RID: 105329 RVA: 0x003BCDD6 File Offset: 0x003BAFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRoleKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B72 RID: 105330 RVA: 0x003BCDF3 File Offset: 0x003BAFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B73 RID: 105331 RVA: 0x003BCDFC File Offset: 0x003BAFFC
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

		// Token: 0x040096A8 RID: 38568
		private UnknownFieldSet _unknownFields;
	}
}
