using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BD RID: 4541
	public sealed class SceneMonsterState : IMessage<SceneMonsterState>, IMessage, IEquatable<SceneMonsterState>, IDeepCloneable<SceneMonsterState>, IBufferMessage
	{
		// Token: 0x060183DC RID: 99292 RVA: 0x00387178 File Offset: 0x00385378
		[NullableContext(1)]
		public static SceneMonsterState Create()
		{
			return new SceneMonsterState();
		}

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x060183DD RID: 99293 RVA: 0x0038717F File Offset: 0x0038537F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051A7 RID: 20903
		// (get) Token: 0x060183DE RID: 99294 RVA: 0x00387182 File Offset: 0x00385382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonsterState.Descriptor;
			}
		}

		// Token: 0x060183DF RID: 99295 RVA: 0x00387189 File Offset: 0x00385389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterState()
		{
		}

		// Token: 0x060183E0 RID: 99296 RVA: 0x00387191 File Offset: 0x00385391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterState(SceneMonsterState other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x003871AA File Offset: 0x003853AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterState Clone()
		{
			return new SceneMonsterState(this);
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x003871B2 File Offset: 0x003853B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonsterState);
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x003871C0 File Offset: 0x003853C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonsterState other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060183E4 RID: 99300 RVA: 0x003871E0 File Offset: 0x003853E0
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

		// Token: 0x060183E5 RID: 99301 RVA: 0x00387206 File Offset: 0x00385406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183E6 RID: 99302 RVA: 0x00387213 File Offset: 0x00385413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183E7 RID: 99303 RVA: 0x0038721C File Offset: 0x0038541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183E8 RID: 99304 RVA: 0x00387234 File Offset: 0x00385434
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

		// Token: 0x060183E9 RID: 99305 RVA: 0x0038725A File Offset: 0x0038545A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMonsterState other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060183EA RID: 99306 RVA: 0x00387277 File Offset: 0x00385477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183EB RID: 99307 RVA: 0x00387280 File Offset: 0x00385480
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

		// Token: 0x04009012 RID: 36882
		private UnknownFieldSet _unknownFields;

		// Token: 0x02001A06 RID: 6662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x02001AB1 RID: 6833
			public enum ENUMS
			{
				// Token: 0x0400D19B RID: 53659
				[OriginalName("NotCreate")]
				NotCreate,
				// Token: 0x0400D19C RID: 53660
				[OriginalName("Alive")]
				Alive,
				// Token: 0x0400D19D RID: 53661
				[OriginalName("Death")]
				Death
			}
		}
	}
}
