using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D22 RID: 3362
	[NetMessage(EMessageId.PhotographPush)]
	public sealed class PhotographPush : IMessage<PhotographPush>, IMessage, IEquatable<PhotographPush>, IDeepCloneable<PhotographPush>, IBufferMessage
	{
		// Token: 0x060122D4 RID: 74452 RVA: 0x002A8130 File Offset: 0x002A6330
		[NullableContext(1)]
		public static PhotographPush Create()
		{
			return new PhotographPush();
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x060122D5 RID: 74453 RVA: 0x002A8137 File Offset: 0x002A6337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x060122D6 RID: 74454 RVA: 0x002A813A File Offset: 0x002A633A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotographPush.Descriptor;
			}
		}

		// Token: 0x060122D7 RID: 74455 RVA: 0x002A8141 File Offset: 0x002A6341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographPush()
		{
		}

		// Token: 0x060122D8 RID: 74456 RVA: 0x002A8149 File Offset: 0x002A6349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographPush(PhotographPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122D9 RID: 74457 RVA: 0x002A8162 File Offset: 0x002A6362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographPush Clone()
		{
			return new PhotographPush(this);
		}

		// Token: 0x060122DA RID: 74458 RVA: 0x002A816A File Offset: 0x002A636A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotographPush);
		}

		// Token: 0x060122DB RID: 74459 RVA: 0x002A8178 File Offset: 0x002A6378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotographPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060122DC RID: 74460 RVA: 0x002A8198 File Offset: 0x002A6398
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

		// Token: 0x060122DD RID: 74461 RVA: 0x002A81BE File Offset: 0x002A63BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122DE RID: 74462 RVA: 0x002A81CB File Offset: 0x002A63CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122DF RID: 74463 RVA: 0x002A81D4 File Offset: 0x002A63D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122E0 RID: 74464 RVA: 0x002A81EC File Offset: 0x002A63EC
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

		// Token: 0x060122E1 RID: 74465 RVA: 0x002A8212 File Offset: 0x002A6412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotographPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060122E2 RID: 74466 RVA: 0x002A822F File Offset: 0x002A642F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122E3 RID: 74467 RVA: 0x002A8238 File Offset: 0x002A6438
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

		// Token: 0x040071F3 RID: 29171
		private UnknownFieldSet _unknownFields;
	}
}
