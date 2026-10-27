using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000967 RID: 2407
	[NetMessage(EMessageId.LowMemoryChangeSceneFinishRequest)]
	public sealed class LowMemoryChangeSceneFinishRequest : IMessage<LowMemoryChangeSceneFinishRequest>, IMessage, IEquatable<LowMemoryChangeSceneFinishRequest>, IDeepCloneable<LowMemoryChangeSceneFinishRequest>, IBufferMessage
	{
		// Token: 0x0600D404 RID: 54276 RVA: 0x001F3B65 File Offset: 0x001F1D65
		[NullableContext(1)]
		public static LowMemoryChangeSceneFinishRequest Create()
		{
			return new LowMemoryChangeSceneFinishRequest();
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0600D405 RID: 54277 RVA: 0x001F3B6C File Offset: 0x001F1D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0600D406 RID: 54278 RVA: 0x001F3B6F File Offset: 0x001F1D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LowMemoryChangeSceneFinishRequest.Descriptor;
			}
		}

		// Token: 0x0600D407 RID: 54279 RVA: 0x001F3B76 File Offset: 0x001F1D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishRequest()
		{
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x001F3B7E File Offset: 0x001F1D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishRequest(LowMemoryChangeSceneFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D409 RID: 54281 RVA: 0x001F3B97 File Offset: 0x001F1D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishRequest Clone()
		{
			return new LowMemoryChangeSceneFinishRequest(this);
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x001F3B9F File Offset: 0x001F1D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LowMemoryChangeSceneFinishRequest);
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x001F3BAD File Offset: 0x001F1DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LowMemoryChangeSceneFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x001F3BCC File Offset: 0x001F1DCC
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

		// Token: 0x0600D40D RID: 54285 RVA: 0x001F3BF2 File Offset: 0x001F1DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x001F3BFF File Offset: 0x001F1DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D40F RID: 54287 RVA: 0x001F3C08 File Offset: 0x001F1E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D410 RID: 54288 RVA: 0x001F3C20 File Offset: 0x001F1E20
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

		// Token: 0x0600D411 RID: 54289 RVA: 0x001F3C46 File Offset: 0x001F1E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LowMemoryChangeSceneFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D412 RID: 54290 RVA: 0x001F3C63 File Offset: 0x001F1E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x001F3C6C File Offset: 0x001F1E6C
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

		// Token: 0x0400590B RID: 22795
		private UnknownFieldSet _unknownFields;
	}
}
