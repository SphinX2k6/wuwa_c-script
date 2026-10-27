using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001164 RID: 4452
	public sealed class SceneItemEventListenerComponentPb : IMessage<SceneItemEventListenerComponentPb>, IMessage, IEquatable<SceneItemEventListenerComponentPb>, IDeepCloneable<SceneItemEventListenerComponentPb>, IBufferMessage
	{
		// Token: 0x06017BD7 RID: 97239 RVA: 0x00372EEB File Offset: 0x003710EB
		[NullableContext(1)]
		public static SceneItemEventListenerComponentPb Create()
		{
			return new SceneItemEventListenerComponentPb();
		}

		// Token: 0x17004FC2 RID: 20418
		// (get) Token: 0x06017BD8 RID: 97240 RVA: 0x00372EF2 File Offset: 0x003710F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06017BD9 RID: 97241 RVA: 0x00372EF5 File Offset: 0x003710F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemEventListenerComponentPb.Descriptor;
			}
		}

		// Token: 0x06017BDA RID: 97242 RVA: 0x00372EFC File Offset: 0x003710FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb()
		{
		}

		// Token: 0x06017BDB RID: 97243 RVA: 0x00372F04 File Offset: 0x00371104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb(SceneItemEventListenerComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017BDC RID: 97244 RVA: 0x00372F29 File Offset: 0x00371129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb Clone()
		{
			return new SceneItemEventListenerComponentPb(this);
		}

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06017BDD RID: 97245 RVA: 0x00372F31 File Offset: 0x00371131
		// (set) Token: 0x06017BDE RID: 97246 RVA: 0x00372F39 File Offset: 0x00371139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06017BDF RID: 97247 RVA: 0x00372F42 File Offset: 0x00371142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemEventListenerComponentPb);
		}

		// Token: 0x06017BE0 RID: 97248 RVA: 0x00372F50 File Offset: 0x00371150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemEventListenerComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BE1 RID: 97249 RVA: 0x00372F80 File Offset: 0x00371180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017BE2 RID: 97250 RVA: 0x00372FBF File Offset: 0x003711BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BE3 RID: 97251 RVA: 0x00372FCC File Offset: 0x003711CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BE4 RID: 97252 RVA: 0x00372FD5 File Offset: 0x003711D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017BE5 RID: 97253 RVA: 0x00373008 File Offset: 0x00371208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017BE6 RID: 97254 RVA: 0x00373046 File Offset: 0x00371246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemEventListenerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017BE7 RID: 97255 RVA: 0x00373077 File Offset: 0x00371277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BE8 RID: 97256 RVA: 0x00373080 File Offset: 0x00371280
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008CED RID: 36077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CEE RID: 36078
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04008CEF RID: 36079
		private long contextId_;
	}
}
