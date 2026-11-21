using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000977 RID: 2423
	[NetMessage(EMessageId.MapMarkInfoRequest)]
	public sealed class MapMarkInfoRequest : IMessage<MapMarkInfoRequest>, IMessage, IEquatable<MapMarkInfoRequest>, IDeepCloneable<MapMarkInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D56D RID: 54637 RVA: 0x001F6BC5 File Offset: 0x001F4DC5
		[NullableContext(1)]
		public static MapMarkInfoRequest Create()
		{
			return new MapMarkInfoRequest();
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600D56E RID: 54638 RVA: 0x001F6BCC File Offset: 0x001F4DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600D56F RID: 54639 RVA: 0x001F6BCF File Offset: 0x001F4DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D570 RID: 54640 RVA: 0x001F6BD6 File Offset: 0x001F4DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoRequest()
		{
		}

		// Token: 0x0600D571 RID: 54641 RVA: 0x001F6BDE File Offset: 0x001F4DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoRequest(MapMarkInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D572 RID: 54642 RVA: 0x001F6BF7 File Offset: 0x001F4DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoRequest Clone()
		{
			return new MapMarkInfoRequest(this);
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x001F6BFF File Offset: 0x001F4DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoRequest);
		}

		// Token: 0x0600D574 RID: 54644 RVA: 0x001F6C0D File Offset: 0x001F4E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D575 RID: 54645 RVA: 0x001F6C2C File Offset: 0x001F4E2C
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

		// Token: 0x0600D576 RID: 54646 RVA: 0x001F6C52 File Offset: 0x001F4E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x001F6C5F File Offset: 0x001F4E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x001F6C68 File Offset: 0x001F4E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x001F6C80 File Offset: 0x001F4E80
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

		// Token: 0x0600D57A RID: 54650 RVA: 0x001F6CA6 File Offset: 0x001F4EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x001F6CC3 File Offset: 0x001F4EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x001F6CCC File Offset: 0x001F4ECC
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

		// Token: 0x040059B8 RID: 22968
		private UnknownFieldSet _unknownFields;
	}
}
