using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A7 RID: 5287
	[NetMessage(EMessageId.TrapDefensePreviewFinishRequest)]
	public sealed class TrapDefensePreviewFinishRequest : IMessage<TrapDefensePreviewFinishRequest>, IMessage, IEquatable<TrapDefensePreviewFinishRequest>, IDeepCloneable<TrapDefensePreviewFinishRequest>, IBufferMessage
	{
		// Token: 0x0601C0EF RID: 114927 RVA: 0x00412DD3 File Offset: 0x00410FD3
		[NullableContext(1)]
		public static TrapDefensePreviewFinishRequest Create()
		{
			return new TrapDefensePreviewFinishRequest();
		}

		// Token: 0x17005EF8 RID: 24312
		// (get) Token: 0x0601C0F0 RID: 114928 RVA: 0x00412DDA File Offset: 0x00410FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EF9 RID: 24313
		// (get) Token: 0x0601C0F1 RID: 114929 RVA: 0x00412DDD File Offset: 0x00410FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601C0F2 RID: 114930 RVA: 0x00412DE4 File Offset: 0x00410FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishRequest()
		{
		}

		// Token: 0x0601C0F3 RID: 114931 RVA: 0x00412DEC File Offset: 0x00410FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishRequest(TrapDefensePreviewFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0F4 RID: 114932 RVA: 0x00412E05 File Offset: 0x00411005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishRequest Clone()
		{
			return new TrapDefensePreviewFinishRequest(this);
		}

		// Token: 0x0601C0F5 RID: 114933 RVA: 0x00412E0D File Offset: 0x0041100D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewFinishRequest);
		}

		// Token: 0x0601C0F6 RID: 114934 RVA: 0x00412E1B File Offset: 0x0041101B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C0F7 RID: 114935 RVA: 0x00412E3C File Offset: 0x0041103C
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

		// Token: 0x0601C0F8 RID: 114936 RVA: 0x00412E62 File Offset: 0x00411062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0F9 RID: 114937 RVA: 0x00412E6F File Offset: 0x0041106F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0FA RID: 114938 RVA: 0x00412E78 File Offset: 0x00411078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0FB RID: 114939 RVA: 0x00412E90 File Offset: 0x00411090
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

		// Token: 0x0601C0FC RID: 114940 RVA: 0x00412EB6 File Offset: 0x004110B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefensePreviewFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0FD RID: 114941 RVA: 0x00412ED3 File Offset: 0x004110D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0FE RID: 114942 RVA: 0x00412EDC File Offset: 0x004110DC
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

		// Token: 0x0400A270 RID: 41584
		private UnknownFieldSet _unknownFields;
	}
}
