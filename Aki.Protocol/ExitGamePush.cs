using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D5 RID: 1237
	[NetMessage(EMessageId.ExitGamePush)]
	public sealed class ExitGamePush : IMessage<ExitGamePush>, IMessage, IEquatable<ExitGamePush>, IDeepCloneable<ExitGamePush>, IBufferMessage
	{
		// Token: 0x060075A9 RID: 30121 RVA: 0x001200D5 File Offset: 0x0011E2D5
		[NullableContext(1)]
		public static ExitGamePush Create()
		{
			return new ExitGamePush();
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x060075AA RID: 30122 RVA: 0x001200DC File Offset: 0x0011E2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x060075AB RID: 30123 RVA: 0x001200DF File Offset: 0x0011E2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitGamePush.Descriptor;
			}
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x001200E6 File Offset: 0x0011E2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitGamePush()
		{
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x001200EE File Offset: 0x0011E2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitGamePush(ExitGamePush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00120107 File Offset: 0x0011E307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitGamePush Clone()
		{
			return new ExitGamePush(this);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x0012010F File Offset: 0x0011E30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitGamePush);
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x0012011D File Offset: 0x0011E31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitGamePush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x0012013C File Offset: 0x0011E33C
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

		// Token: 0x060075B2 RID: 30130 RVA: 0x00120162 File Offset: 0x0011E362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x0012016F File Offset: 0x0011E36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00120178 File Offset: 0x0011E378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00120190 File Offset: 0x0011E390
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

		// Token: 0x060075B6 RID: 30134 RVA: 0x001201B6 File Offset: 0x0011E3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitGamePush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x001201D3 File Offset: 0x0011E3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x001201DC File Offset: 0x0011E3DC
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

		// Token: 0x04003E13 RID: 15891
		private UnknownFieldSet _unknownFields;
	}
}
