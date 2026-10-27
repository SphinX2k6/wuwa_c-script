using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001183 RID: 4483
	public sealed class SceneMonsterState : IMessage<SceneMonsterState>, IMessage, IEquatable<SceneMonsterState>, IDeepCloneable<SceneMonsterState>, IBufferMessage
	{
		// Token: 0x06017E3B RID: 97851 RVA: 0x00377E34 File Offset: 0x00376034
		[NullableContext(1)]
		public static SceneMonsterState Create()
		{
			return new SceneMonsterState();
		}

		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x06017E3C RID: 97852 RVA: 0x00377E3B File Offset: 0x0037603B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x06017E3D RID: 97853 RVA: 0x00377E3E File Offset: 0x0037603E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonsterState.Descriptor;
			}
		}

		// Token: 0x06017E3E RID: 97854 RVA: 0x00377E45 File Offset: 0x00376045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterState()
		{
		}

		// Token: 0x06017E3F RID: 97855 RVA: 0x00377E4D File Offset: 0x0037604D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterState(SceneMonsterState other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E40 RID: 97856 RVA: 0x00377E66 File Offset: 0x00376066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterState Clone()
		{
			return new SceneMonsterState(this);
		}

		// Token: 0x06017E41 RID: 97857 RVA: 0x00377E6E File Offset: 0x0037606E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonsterState);
		}

		// Token: 0x06017E42 RID: 97858 RVA: 0x00377E7C File Offset: 0x0037607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonsterState other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06017E43 RID: 97859 RVA: 0x00377E9C File Offset: 0x0037609C
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

		// Token: 0x06017E44 RID: 97860 RVA: 0x00377EC2 File Offset: 0x003760C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E45 RID: 97861 RVA: 0x00377ECF File Offset: 0x003760CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E46 RID: 97862 RVA: 0x00377ED8 File Offset: 0x003760D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E47 RID: 97863 RVA: 0x00377EF0 File Offset: 0x003760F0
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

		// Token: 0x06017E48 RID: 97864 RVA: 0x00377F16 File Offset: 0x00376116
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

		// Token: 0x06017E49 RID: 97865 RVA: 0x00377F33 File Offset: 0x00376133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E4A RID: 97866 RVA: 0x00377F3C File Offset: 0x0037613C
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

		// Token: 0x04008D7F RID: 36223
		private UnknownFieldSet _unknownFields;

		// Token: 0x0200197A RID: 6522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x02001A0F RID: 6671
			public enum ENUMS
			{
				// Token: 0x0400CC31 RID: 52273
				[OriginalName("NotCreate")]
				NotCreate,
				// Token: 0x0400CC32 RID: 52274
				[OriginalName("Alive")]
				Alive,
				// Token: 0x0400CC33 RID: 52275
				[OriginalName("Death")]
				Death
			}
		}
	}
}
