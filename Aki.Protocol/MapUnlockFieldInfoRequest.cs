using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000996 RID: 2454
	[NetMessage(EMessageId.MapUnlockFieldInfoRequest)]
	public sealed class MapUnlockFieldInfoRequest : IMessage<MapUnlockFieldInfoRequest>, IMessage, IEquatable<MapUnlockFieldInfoRequest>, IDeepCloneable<MapUnlockFieldInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D7CF RID: 55247 RVA: 0x001FBA55 File Offset: 0x001F9C55
		[NullableContext(1)]
		public static MapUnlockFieldInfoRequest Create()
		{
			return new MapUnlockFieldInfoRequest();
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0600D7D0 RID: 55248 RVA: 0x001FBA5C File Offset: 0x001F9C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x001FBA5F File Offset: 0x001F9C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapUnlockFieldInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D7D2 RID: 55250 RVA: 0x001FBA66 File Offset: 0x001F9C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoRequest()
		{
		}

		// Token: 0x0600D7D3 RID: 55251 RVA: 0x001FBA6E File Offset: 0x001F9C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoRequest(MapUnlockFieldInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x001FBA87 File Offset: 0x001F9C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapUnlockFieldInfoRequest Clone()
		{
			return new MapUnlockFieldInfoRequest(this);
		}

		// Token: 0x0600D7D5 RID: 55253 RVA: 0x001FBA8F File Offset: 0x001F9C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapUnlockFieldInfoRequest);
		}

		// Token: 0x0600D7D6 RID: 55254 RVA: 0x001FBA9D File Offset: 0x001F9C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapUnlockFieldInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x001FBABC File Offset: 0x001F9CBC
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

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x001FBAE2 File Offset: 0x001F9CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7D9 RID: 55257 RVA: 0x001FBAEF File Offset: 0x001F9CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7DA RID: 55258 RVA: 0x001FBAF8 File Offset: 0x001F9CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7DB RID: 55259 RVA: 0x001FBB10 File Offset: 0x001F9D10
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

		// Token: 0x0600D7DC RID: 55260 RVA: 0x001FBB36 File Offset: 0x001F9D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapUnlockFieldInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x001FBB53 File Offset: 0x001F9D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7DE RID: 55262 RVA: 0x001FBB5C File Offset: 0x001F9D5C
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

		// Token: 0x04005A4D RID: 23117
		private UnknownFieldSet _unknownFields;
	}
}
